using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaterialUpdate : MonoBehaviour
{
    [SerializeField] private Color[] _sphereMaterials;
    [SerializeField] private Color[] _cubeMaterials;
    
    [SerializeField] private Renderer _sphere;
    [SerializeField] private Renderer _cube;
    
    public static int _currentSphereMaterialIndex = -1;
    public static int _currentCubeMaterialIndex = -1;

    public void UpdateSphereMaterial(int index)
    {
        var mat = _sphere.material;
        mat.color = _sphereMaterials[index];
        _sphere.material = mat;
        _currentSphereMaterialIndex = index;
    }
    
    public void UpdateCubeMaterial(int index)
    {
        var mat = _cube.material;
        mat.color = _cubeMaterials[index];
        _cube.material = mat;
        _currentCubeMaterialIndex = index;
    }
    
    public void UpdateSphereMaterial(Material material)
    {
        _sphere.material = material;
    }
    
    public void UpdateCubeMaterial(Material material)
    {
        _cube.material = material;
    }
}
