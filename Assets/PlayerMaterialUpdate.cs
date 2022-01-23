using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaterialUpdate : MonoBehaviour
{
    [SerializeField] private Material[] _sphereMaterials;
    [SerializeField] private Material[] _cubeMaterials;
    
    [SerializeField] private Renderer _sphere;
    [SerializeField] private Renderer _cube;
    
    public static int _currentSphereMaterialIndex = -1;
    public static int _currentCubeMaterialIndex = -1;

    public void UpdateSphereMaterial(int index)
    {
        _sphere.material = _sphereMaterials[index];
        _currentSphereMaterialIndex = index;
    }
    
    public void UpdateCubeMaterial(int index)
    {
        _cube.material = _cubeMaterials[index];
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
