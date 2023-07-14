using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassOffset : MonoBehaviour
{
    public Transform Target;
    [SerializeField] private Material _edgeMaterial;
    [SerializeField] private MeshRenderer _edgeMeshRenderer;

    [Header("Shader Reference")]
    [SerializeField] private string _protagonistPosition = "_ProtagonistPosition";

    private BoxCollider _boxCollider;
    private void Awake()
    {
        _edgeMeshRenderer = GetComponent<MeshRenderer>();
        _edgeMaterial = new Material(_edgeMaterial);
        _edgeMeshRenderer.material = _edgeMaterial;
        _boxCollider = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        if (Target!= null)
        {
            _edgeMaterial.SetVector(_protagonistPosition, Target.position);
        }

    }
}
