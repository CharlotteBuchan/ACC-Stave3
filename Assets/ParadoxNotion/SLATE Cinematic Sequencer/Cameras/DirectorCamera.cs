﻿using UnityEngine;

namespace Slate
{

    ///<summary>The master director render camera for all cutscenes.</summary>
    public class DirectorCamera : MonoBehaviour, IDirectableCamera
    {
        public const float DEFAULT_FOCAL_DISTANCE = 0.1f;
        public const float DEFAULT_FOCAL_LENGTH = 0f;
        public const float DEFAULT_FOCAL_APERTURE = 0.1f;

        [SerializeField, HideInInspector]
        private bool _autoHandleActiveState = true;
        [SerializeField, HideInInspector]
        private bool _matchMainWhenActive = true;
        [SerializeField, HideInInspector]
        private bool _setMainWhenActive = true;
        [SerializeField, HideInInspector]
        private bool _ignoreFOVChanges = false;
        [SerializeField, HideInInspector]
        private bool _dontDestroyOnLoad = false;

#if SLATE_USE_HDRP || SLATE_USE_URP
        [SerializeField, HideInInspector]
        private UnityEngine.Rendering.Volume _globalPostVolume;
#elif SLATE_USE_POSTSTACK
        [SerializeField, HideInInspector]
        private UnityEngine.Rendering.PostProcessing.PostProcessVolume _globalPostVolume;
#endif


        //max possible damp able to be used for post-smoothing
        public const float MAX_DAMP = 3f;

        ///<summary>Raised when a camera cut takes place from one shot to another.</summary>
        public static event System.Action<IDirectableCamera> onCut;
        ///<summary>Raised when the Director Camera is activated/enabled.</summary>
        public static event System.Action onActivate;
        ///<summary>Raised when the Director Camera is deactivated/disabled.</summary>
        public static event System.Action onDeactivate;

        private static DirectorCamera _current;
        private static Camera _cam;
        private static IDirectableCamera lastTargetShot;

#if SLATE_USE_HDRP
        private static UnityEngine.Rendering.HighDefinition.DepthOfField postDOF;
#elif SLATE_USE_URP
        private static UnityEngine.Rendering.Universal.DepthOfField postDOF;
#elif SLATE_USE_POSTSTACK
        private static UnityEngine.Rendering.PostProcessing.DepthOfField postDOF;
#endif

        public static DirectorCamera current {
            get
            {
                if ( _current == null ) {
                    _current = FindAnyObjectByType<DirectorCamera>();
                    if ( _current == null ) {
#if UNITY_EDITOR
                        if ( !Prefs.autoCreateDirectorCamera ) { return null; }
#endif
                        _current = new GameObject("★ Director Camera Root").AddComponent<DirectorCamera>();
                        _current.cam.nearClipPlane = 0.01f;
                        _current.cam.farClipPlane = 1000;
                    }
                }
                return _current;
            }
        }

        ///----------------------------------------------------------------------------------------------

        public Camera cam {
            get
            {
                if ( _cam == null ) {
                    _cam = GetComponentInChildren<Camera>(true);
                    if ( _cam == null ) {
                        _cam = CreateRenderCamera();
                    }
                }
                return _cam;
            }
        }

        ///----------------------------------------------------------------------------------------------

        //These properties are instance properties so that they can potentially be animated.
        public Vector3 position {
            get { return current.transform.position; }
            set { current.transform.position = value; }
        }

        public Quaternion rotation {
            get { return current.transform.rotation; }
            set { current.transform.rotation = value; }
        }

        public float fieldOfView {
            get { return cam.orthographic ? cam.orthographicSize : cam.fieldOfView; }
            set { if ( !ignoreFOVChanges ) { cam.fieldOfView = value; cam.orthographicSize = value; } }
        }

#if SLATE_USE_HDRP
        public float focalDistance {
            get { return postDOF != null ? postDOF.focusDistance.value : DEFAULT_FOCAL_DISTANCE; }
            set { if ( postDOF != null ) postDOF.focusDistance.value = value; }
        }
        public float focalLength {
            get { return renderCamera.focalLength; }
            set { renderCamera.focalLength = value; }
        }
        public float focalAperture {
            get { return renderCamera.GetComponent<UnityEngine.Rendering.HighDefinition.HDAdditionalCameraData>().physicalParameters.aperture; }
            set { renderCamera.GetComponent<UnityEngine.Rendering.HighDefinition.HDAdditionalCameraData>().physicalParameters.aperture = value; }
        }
#elif SLATE_USE_URP
        public float focalDistance {
            get { return postDOF != null ? postDOF.focusDistance.value : DEFAULT_FOCAL_DISTANCE; }
            set { if ( postDOF != null ) postDOF.focusDistance.value = value; }
        }
        public float focalLength {
            get { return postDOF != null ? postDOF.focalLength.value : DEFAULT_FOCAL_LENGTH; }
            set { if ( postDOF != null ) postDOF.focalLength.value = value; }
        }
        public float focalAperture {
            get { return postDOF != null ? postDOF.aperture.value : DEFAULT_FOCAL_APERTURE; }
            set { if ( postDOF != null ) postDOF.aperture.value = value; }
        }
#elif SLATE_USE_POSTSTACK
        public float focalDistance {
            get { return postDOF != null ? postDOF.focusDistance.value : DEFAULT_FOCAL_DISTANCE; }
            set { if ( postDOF != null ) postDOF.focusDistance.value = value; }
        }

        public float focalLength {
            get { return postDOF != null ? postDOF.focalLength.value : DEFAULT_FOCAL_LENGTH; }
            set { if ( postDOF != null ) postDOF.focalLength.value = value; }
        }

        public float focalAperture {
            get { return postDOF != null ? postDOF.aperture.value : DEFAULT_FOCAL_APERTURE; }
            set { if ( postDOF != null ) postDOF.aperture.value = value; }
        }
#else
        public float focalDistance { get; set; }
        public float focalLength { get; set; }
        public float focalAperture { get; set; }
#endif

        ///----------------------------------------------------------------------------------------------

        ///<summary>Should DirectorCamera be matched to Camera.main when active?</summary>
        public static bool matchMainWhenActive {
            get { return current._matchMainWhenActive; }
            set { current._matchMainWhenActive = value; }
        }

        ///<summary>Should DirectorCamera be set as Camera.main when active?</summary>
        public static bool setMainWhenActive {
            get { return current._setMainWhenActive; }
            set { current._setMainWhenActive = value; }
        }

        ///<summary>If true, the RenderCamera active state is automatically handled. This is highly recommended.</summary>
        public static bool autoHandleActiveState {
            get { return current._autoHandleActiveState; }
            set { current._autoHandleActiveState = value; }
        }

        ///<summary>If true, any changes made by shots will be bypassed/ignored.</summary>
        public static bool ignoreFOVChanges {
            get { return current._ignoreFOVChanges; }
            set { current._ignoreFOVChanges = value; }
        }

        ///<summary>Should DirectorCamera be persistant between level changes?</summary>
        public static bool dontDestroyOnLoad {
            get { return current._dontDestroyOnLoad; }
            set { current._dontDestroyOnLoad = value; }
        }

#if SLATE_USE_HDRP || SLATE_USE_URP
        ///<summary>The post-processing volume to use for game blending DoF</summary>
        public static UnityEngine.Rendering.Volume globalPostVolume {
            get { return _current._globalPostVolume; }
            set { current._globalPostVolume = value; }
        }
#elif SLATE_USE_POSTSTACK
        ///<summary>The post-processing volume to use for game blending DoF</summary>
        public static UnityEngine.Rendering.PostProcessing.PostProcessVolume globalPostVolume {
            get { return _current._globalPostVolume; }
            set { current._globalPostVolume = value; }
        }
#endif

        ///<summary>The actual camera from within cutscenes are rendered</summary>
        public static Camera renderCamera { get { return current.cam; } }
        ///<summary>The gameplay camera</summary>
        public static GameCamera gameCamera { get; set; }
        ///<summary>Is director enabled?</summary>
        public static bool isEnabled { get; private set; }

        ///----------------------------------------------------------------------------------------------

        //...
        void Awake() {

            if ( _current != null && _current != this ) {
                DestroyImmediate(this.gameObject);
                return;
            }

            _current = this;
            if ( dontDestroyOnLoad ) {
                DontDestroyOnLoad(this.gameObject);
            }
            Disable();
        }

        //...
        Camera CreateRenderCamera() {
            _cam = new GameObject("Render Camera").AddComponent<Camera>();
            _cam.gameObject.AddComponent<AudioListener>();
            _cam.gameObject.AddComponent<FlareLayer>();
            _cam.transform.SetParent(this.transform);
            return _cam;
        }

        ///<summary>Enable the Director Camera, while disabling the main camera if any</summary>
        public static void Enable() {

            //init gamecamera if any
            if ( gameCamera == null ) {
                var main = Camera.main;
                if ( main != null && main != renderCamera ) {
                    gameCamera = main.GetAddComponent<GameCamera>();
                }
            }

            //use gamecamera and disable it
            if ( gameCamera != null ) {
                gameCamera.gameObject.SetActive(false);
                if ( matchMainWhenActive ) {
                    var tempFOV = current.fieldOfView;
                    renderCamera.CopyFrom(gameCamera.cam);
#if SLATE_USE_HDRP
                    gameCamera.GetComponent<UnityEngine.Rendering.HighDefinition.HDAdditionalCameraData>().CopyTo(renderCamera.GetComponent<UnityEngine.Rendering.HighDefinition.HDAdditionalCameraData>());
#elif SLATE_USE_URP
                    //Universal does not have a CopyTo. Soo..:
                    renderCamera.GetAddComponent<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData>().renderPostProcessing = true;
                    if ( gameCamera.TryGetComponent<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData>(out var cData) ) {
                        renderCamera.GetComponent<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData>().antialiasing = cData.antialiasing;
                    }
#endif
                    if ( ignoreFOVChanges ) {
                        renderCamera.fieldOfView = tempFOV;
                    }
                }

                //set the root pos/rot
                current.transform.position = gameCamera.position;
                current.transform.rotation = gameCamera.rotation;
            }

            //reset render camera local pos/rot
            renderCamera.transform.localPosition = Vector3.zero;
            renderCamera.transform.localRotation = Quaternion.identity;

            //set render camera to MainCamera if option enabled
            if ( setMainWhenActive ) {
                renderCamera.gameObject.tag = "MainCamera";
            }

            //enable
            if ( autoHandleActiveState ) {
                renderCamera.gameObject.SetActive(true);
            }

#if SLATE_USE_HDRP
            var volume = renderCamera.GetAddComponent<UnityEngine.Rendering.Volume>();
            volume.isGlobal = true;
            volume.priority = int.MaxValue;
            if ( volume.profile == null ) {
                volume.profile = ScriptableObject.CreateInstance<UnityEngine.Rendering.VolumeProfile>();
            }
            if ( !volume.profile.TryGet<UnityEngine.Rendering.HighDefinition.DepthOfField>(out postDOF) ) {
                postDOF = volume.profile.Add<UnityEngine.Rendering.HighDefinition.DepthOfField>();
                postDOF.focusMode = new UnityEngine.Rendering.HighDefinition.DepthOfFieldModeParameter(UnityEngine.Rendering.HighDefinition.DepthOfFieldMode.UsePhysicalCamera);
                postDOF.focusMode.overrideState = true;
                postDOF.focusDistance.overrideState = true;
                postDOF.active = true;
            }

#elif SLATE_USE_URP
            var volume = renderCamera.GetAddComponent<UnityEngine.Rendering.Volume>();
            volume.isGlobal = true;
            volume.priority = int.MaxValue;
            if ( volume.profile == null ) {
                volume.profile = ScriptableObject.CreateInstance<UnityEngine.Rendering.VolumeProfile>();
            }
            if ( !volume.profile.TryGet<UnityEngine.Rendering.Universal.DepthOfField>(out postDOF) ) {
                postDOF = volume.profile.Add<UnityEngine.Rendering.Universal.DepthOfField>();
                postDOF.mode = new UnityEngine.Rendering.Universal.DepthOfFieldModeParameter(UnityEngine.Rendering.Universal.DepthOfFieldMode.Bokeh);
                postDOF.mode.overrideState = true;
                postDOF.focalLength.overrideState = true;
                postDOF.focusDistance.overrideState = true;
                postDOF.aperture.overrideState = true;
            }

#elif SLATE_USE_POSTSTACK
            var volume = renderCamera.GetAddComponent<UnityEngine.Rendering.PostProcessing.PostProcessVolume>();
            volume.isGlobal = true;
            volume.priority = int.MaxValue;
            if ( volume.profile == null ) {
                volume.profile = ScriptableObject.CreateInstance<UnityEngine.Rendering.PostProcessing.PostProcessProfile>();
            }
            if ( !volume.profile.TryGetSettings<UnityEngine.Rendering.PostProcessing.DepthOfField>(out postDOF) ) {
                postDOF = volume.profile.AddSettings<UnityEngine.Rendering.PostProcessing.DepthOfField>();
                postDOF.focalLength.overrideState = true;
                postDOF.focusDistance.overrideState = true;
                postDOF.aperture.overrideState = true;
                postDOF.active = true;
            }
            var layer = renderCamera.GetAddComponent<UnityEngine.Rendering.PostProcessing.PostProcessLayer>();
            if ( globalPostVolume != null ) {
                renderCamera.gameObject.layer = globalPostVolume.gameObject.layer;
                layer.volumeLayer = LayerMask.GetMask(LayerMask.LayerToName(globalPostVolume.gameObject.layer));
            } else {
                renderCamera.gameObject.layer = LayerMask.NameToLayer("Ignore Raycast");
                layer.volumeLayer = LayerMask.GetMask("Ignore Raycast");
            }
#endif

            isEnabled = true;
            lastTargetShot = null;

            if ( onActivate != null ) {
                onActivate();
            }
        }

        ///<summary>Disable the Director Camera, while enabling back the main camera if any</summary>
        public static void Disable() {

            if ( onDeactivate != null ) {
                onDeactivate();
            }

            //disable render camera
            if ( autoHandleActiveState ) {
                renderCamera.gameObject.SetActive(false);
            }

            //reset tag
            if ( setMainWhenActive ) {
                renderCamera.gameObject.tag = "Untagged";
            }

            //enable gamecamera
            if ( gameCamera != null ) {
                gameCamera.gameObject.SetActive(true);
            }

            isEnabled = false;
        }


        ///<summary>Ease from game camera to target. If target is null, eases to DirectorCamera current.</summary>
        public static void Update(IDirectableCamera source, IDirectableCamera target, EaseType interpolation, float weight, float damping = 0f) {

            if ( source == null ) { source = gameCamera != null ? (IDirectableCamera)gameCamera : (IDirectableCamera)current; }
            if ( target == null ) { target = current; }
            var isCut = target != lastTargetShot;

            var endPosition = weight < 1 ? Easing.Ease(interpolation, source.position, target.position, weight) : target.position;
            var endRotation = weight < 1 ? Easing.Ease(interpolation, source.rotation, target.rotation, weight) : target.rotation;
            var endFOV = weight < 1 ? Easing.Ease(interpolation, source.fieldOfView, target.fieldOfView, weight) : target.fieldOfView;
            var endFocalDistance = weight < 1 ? Easing.Ease(interpolation, source.focalDistance, target.focalDistance, weight) : target.focalDistance;
            var endFocalLength = weight < 1 ? Easing.Ease(interpolation, source.focalLength, target.focalLength, weight) : target.focalLength;
            var endFocalAperture = weight < 1 ? Easing.Ease(interpolation, source.focalAperture, target.focalAperture, weight) : target.focalAperture;

#if UNITY_EDITOR
            var dofChange = current.focalDistance != target.focalDistance || current.focalLength != target.focalLength || current.focalAperture != target.focalAperture;
#endif

            if ( !isCut && damping > 0 ) {
                current.position = Vector3.Lerp(current.position, endPosition, Time.deltaTime * ( MAX_DAMP / damping ));
                current.rotation = Quaternion.Lerp(current.rotation, endRotation, Time.deltaTime * ( MAX_DAMP / damping ));
                current.fieldOfView = Mathf.Lerp(current.fieldOfView, endFOV, Time.deltaTime * ( MAX_DAMP / damping ));
                current.focalDistance = Mathf.Lerp(current.focalDistance, endFocalDistance, Time.deltaTime * ( MAX_DAMP / damping ));
                current.focalLength = Mathf.Lerp(current.focalLength, endFocalLength, Time.deltaTime * ( MAX_DAMP / damping ));
                current.focalAperture = Mathf.Lerp(current.focalAperture, endFocalAperture, Time.deltaTime * ( MAX_DAMP / damping ));

            } else {
                current.position = endPosition;
                current.rotation = endRotation;
                current.fieldOfView = endFOV;
                current.focalDistance = endFocalDistance;
                current.focalLength = endFocalLength;
                current.focalAperture = endFocalAperture;
            }

            if ( isCut ) {
                if ( onCut != null ) {
                    onCut(target);
                }
            }


#if UNITY_EDITOR && ( SLATE_USE_POSTSTACK || SLATE_USE_URP )
            //FIXME: temp solution to force the DOF changes render in realtime when in editor
            if ( !Application.isPlaying && ( isCut || dofChange ) ) {
                UnityEditorInternal.InternalEditorUtility.RepaintAllViews();
            }
#endif

            lastTargetShot = target;
        }


        ///----------------------------------------------------------------------------------------------

        private static float noiseTimer;
        private static Vector3 noisePosOffset;
        private static Vector3 noiseRotOffset;
        private static Vector3 noiseTargetPosOffset;
        private static Vector3 noiseTargetRotOffset;
        private static Vector3 noiseCamPosVel;
        private static Vector3 noiseCamRotVel;
        //Apply noise effect (steadycam). This is better looking than using a multi Perlin noise.
        public static void ApplyNoise(float magnitude, float weight) {
            var posMlt = Mathf.Lerp(0.2f, 0.4f, magnitude);
            var rotMlt = Mathf.Lerp(5, 10f, magnitude);
            var damp = Mathf.Lerp(3, 1, magnitude);
            if ( noiseTimer <= 0 ) {
                noiseTimer = Random.Range(0.2f, 0.3f);
                noiseTargetPosOffset = Random.insideUnitSphere * posMlt;
                noiseTargetRotOffset = Random.insideUnitSphere * rotMlt;
            }
            noiseTimer -= Time.deltaTime;

            noisePosOffset = Vector3.SmoothDamp(noisePosOffset, noiseTargetPosOffset, ref noiseCamPosVel, damp);
            noiseRotOffset = Vector3.SmoothDamp(noiseRotOffset, noiseTargetRotOffset, ref noiseCamRotVel, damp);

            //Noise is applied as a local offset to the RenderCamera directly
            renderCamera.transform.localPosition = Vector3.Lerp(Vector3.zero, noisePosOffset, weight);
            renderCamera.transform.SetLocalEulerAngles(Vector3.Lerp(Vector3.zero, noiseRotOffset, weight));
        }

        ///----------------------------------------------------------------------------------------------



        ///----------------------------------------------------------------------------------------------
        ///---------------------------------------UNITY EDITOR-------------------------------------------
#if UNITY_EDITOR

        void Reset() {
            CreateRenderCamera();
            Disable();
        }

        void OnValidate() { }

        void OnDrawGizmos() {

            var color = Prefs.gizmosColor;
            if ( !isEnabled ) { color.a = 0.2f; }
            Gizmos.color = color;

            var hit = new RaycastHit();
            if ( Physics.Linecast(cam.transform.position, cam.transform.position - new Vector3(0, 100, 0), out hit) ) {
                var d = Vector3.Distance(hit.point, cam.transform.position);
                Gizmos.DrawLine(cam.transform.position, hit.point);
                Gizmos.DrawCube(hit.point, new Vector3(0.2f, 0.05f, 0.2f));
                Gizmos.DrawCube(hit.point + new Vector3(0, d / 2, 0), new Vector3(0.02f, d, 0.02f));
            }

            Gizmos.DrawLine(transform.position, cam.transform.position);

            if ( isEnabled ) { color = Color.green; }
            Gizmos.color = color;
            Gizmos.matrix = Matrix4x4.TRS(cam.transform.position, cam.transform.rotation, Vector3.one);
            var dist = isEnabled ? 0.8f : 0.5f;
            Gizmos.DrawFrustum(new Vector3(0, 0, dist), fieldOfView, 0, dist, 1);

            color.a = 0.2f;
            Gizmos.color = color;
            Gizmos.matrix = Matrix4x4.TRS(transform.position, transform.rotation, Vector3.one);
            Gizmos.DrawFrustum(new Vector3(0, 0, 0.5f), fieldOfView, 0f, 0.5f, 1);
            Gizmos.color = Color.white;
        }

#endif
    }
}