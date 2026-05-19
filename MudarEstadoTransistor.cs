using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MudarEstadoTransistor : MonoBehaviour
{
    public Material materialAtivo;
    private Material materialOriginal;
    private MeshRenderer meshRenderer;
    private AudioSource audioSource;
    private bool emDeplecao = false;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        materialOriginal = meshRenderer.material;
        audioSource = GetComponent<AudioSource>();
    }

    // Função chamada pelo evento de OnSelect do XR Simple Interactable
    public void AlternarEstado()
    {
        emDeplecao = !emDeplecao;
        
        if (emDeplecao)
        {
            meshRenderer.material = materialAtivo;
            if (audioSource != null) audioSource.Play();
        }
        else
        {
            meshRenderer.material = materialOriginal;
        }
    }
}