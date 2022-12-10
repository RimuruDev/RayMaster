#### [[На русском языки](/README_ru.md) - [In Russian](/README_ru.md)] | [[На английском языки](/README.md) - [In English](/README.md)]

# :pushpin:RayMaster [helper]
# How to use
Move the unitypackage or Scripts folder to unity.

## Don't forget NameSpace 
```csharp
using RimuruDev.RayMaster;
```


#  Ray.Get<>();
Takes a component from the object touched by the ray.
```csharp
if (Input.GetMouseButtonDown(0))
{
    var trueComponent = Ray.Get<IColor>();

    if (trueComponent != null)
    {
        trueComponent.GetComponent<IColor>().Swith();
    }
    else
        Debug.Log("Miss");
}
```
#  Ray.Get<>(out T value);
Safely takes the component from the object touched by the beam. It is more convenient for frequent use.
```csharp
if (Input.GetMouseButtonDown(0))
{
    if (Ray.Get<IColor>(out var color))
    {
        color.Swith();
    }
    else
        Debug.Log("Miss");
}

```

#  Ray.TryGet<>(out T component)
Safely takes the component from the object touched by the beam.
```csharp
if (Input.GetMouseButtonDown(0))
{
    if (Ray.TryGet<IColor>(out var component))
    {
        component.Swith();
    }
    else
        Debug.Log("Miss");
}

```

# Ray.GetCameraCenter();
Method Ray.GetCameraCenter() returned UnityEngine.Ray in center camera.
```csharp
var ray = Ray.GetCameraCenter();
```
# Ray.RayCamera { get; set; }
Property for get and set ray camera.
```csharp
[SerializeField] private Camera CameraCamera;

private void Start() => Ray.RayCamera = CameraCamera;
```
# GetRay()
Returns the touch hit of the beam.
```csharp
if (Ray.GetRey().transform.CompareTag("Player"))
{
    // code ...
}
```

# :pushpin:Nested class RayMasterInfo

# IsCameraInit { get; }
Returns true if the camera reference is not-null and false if the camera reference is null.
```csharp
if (Ray.RayMasterInfo.IsCameraInit) { }
```
# CameraName { get; }
Returns the current camera name.
```csharp
Debug.Log($"Camera name: {Ray.RayMasterInfo.CameraName}");
```
# CameraGameObject { get; }
Returns the current camera gameObject.
```csharp
var cameraObject = Ray.RayMasterInfo.CameraGameObject;
```
