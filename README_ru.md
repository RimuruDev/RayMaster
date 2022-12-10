#### [[На русском языки](/README_ru.md) - [In Russian](/README_ru.md)] | [[На английском языки](/README.md) - [In English](/README.md)]

# :pushpin:RayMaster [helper]
# Как использовать?
Переместите папку .unitypackage или Scripts в единство. Также можно скачать последний релиз и перенести его в unity. 

## Не забывайте добавить NameSpace
```csharp
using RimuruDev.RayMaster;
```


#  Ray.Get<>();
Берет компонент из объекта, которого коснулся луч.
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
Безопасно снимает компонент с объекта, которого коснулся луч.  Это более удобно для частого использования.
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
Безопасно снимает компонент с объекта, которого коснулся луч.
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
Метод Ray.GetCameraCenter() возвращает UnityEngine.Ray в центре камере. Другими словами, возвращает центр экрана.
```csharp
var ray = Ray.GetCameraCenter();
```
# Ray.RayCamera { get; set; }
Свойство для получения и установки лучевой камеры.
```csharp
[SerializeField] private Camera CameraCamera;

private void Start() => Ray.RayCamera = CameraCamera;
```
# GetRay()
Возвращает касание луча.
```csharp
if (Ray.GetRey().transform.CompareTag("Player"))
{
    // code ...
}
```

# :pushpin:Вложенный класс RayMasterInfo

# IsCameraInit { get; }
Возвращает значение true, если ссылка на камеру не равна нулю, и значение false, если ссылка на камеру равна нулю.
```csharp
if (Ray.RayMasterInfo.IsCameraInit) { }
```
# CameraName { get; }
Возвращает текущее имя камеры.
```csharp
Debug.Log($"Camera name: {Ray.RayMasterInfo.CameraName}");
```
# CameraGameObject { get; }
Возвращает текущий игровой объект камеры.
```csharp
var cameraObject = Ray.RayMasterInfo.CameraGameObject;
```
