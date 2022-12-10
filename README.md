#### [[На русском языки](/README_ru.md) - [In Russian](/README_ru.md)] | [[На английском языки](/README.md) - [In English](/README.md)]

# :pushpin:RayMaster [helper]

<p align="center">
  <a>
    <img alt="Made With Unity" src="https://img.shields.io/badge/made%20with-Unity-57b9d3.svg?logo=Unity">
  </a>
  <a>
    <img alt="License" src="https://img.shields.io/github/license/RimuruDev/RayMaster?logo=github">
  </a>
  <a>
    <img alt="Last Commit" src="https://img.shields.io/github/last-commit/RimuruDev/RayMaster?logo=Mapbox&color=orange">
  </a>
  <a>
    <img alt="Repo Size" src="https://img.shields.io/github/repo-size/RimuruDev/RayMaster?logo=VirtualBox">
  </a>
  <a>
    <img alt="Downloads" src="https://img.shields.io/github/downloads/RimuruDev/RayMaster/total?color=brightgreen">
  </a>
  <a>
    <img alt="Last Release" src="https://img.shields.io/github/v/release/RimuruDev/RayMaster?include_prereleases&logo=Dropbox&color=yellow">
  </a>
  <a>
    <img alt="GitHub stars" src="https://img.shields.io/github/stars/RimuruDev/RayMaster?branch=main&label=Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="GitHub user stars" src="https://img.shields.io/github/stars/RimuruDev?affiliations=OWNER&branch=main&label=User%20Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
</p>

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
