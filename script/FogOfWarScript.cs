using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogOfWarScript : MonoBehaviour
{

    public GameObject m_fogOfWarPlane;
    public Transform m_player;
    public Transform m_player2;
    public LayerMask m_fogLayer;
    public float m_radius1;
    private float m_radiusSqr1;
    public float m_radius2;
    private float m_radiusSqr2;

    private Mesh m_mesh;
    private Vector3[] m_vertices;
    private Color[] m_colors;

    // Use this for initialization
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        m_radiusSqr1 = m_radius1 * m_radius1;
        m_radiusSqr2 = m_radius2 * m_radius2;
        Ray r = new Ray(transform.position, m_player.position - transform.position);
        Ray d = new Ray(transform.position, m_player2.position - transform.position);

        RaycastHit hit;
        if (Physics.Raycast(r, out hit, 1000, m_fogLayer, QueryTriggerInteraction.Collide))
        {
            for (int i = 0; i < m_vertices.Length; i++)
            {
                m_colors[i] = Color.black;
                Vector3 v = m_fogOfWarPlane.transform.TransformPoint(m_vertices[i]);
                float dist = Vector3.SqrMagnitude(v - hit.point);
                if (dist < m_radiusSqr1)
                {
                    float alpha = Mathf.Min(m_colors[i].a, dist / m_radiusSqr1);
                    m_colors[i].a = alpha;
                }
            }
            UpdateColor();
        }
        if (Physics.Raycast(d, out hit, 1000, m_fogLayer, QueryTriggerInteraction.Collide))
        {
            for (int i = 0; i < m_vertices.Length; i++)
            {
                Vector3 v = m_fogOfWarPlane.transform.TransformPoint(m_vertices[i]);
                float dist = Vector3.SqrMagnitude(v - hit.point);
                if (dist < m_radiusSqr2)
                {
                    float alpha = Mathf.Min(m_colors[i].a, dist / m_radiusSqr2);
                    m_colors[i].a = alpha;
                }
            }
            UpdateColor();
        }
    }


    void Initialize()
    {
        m_mesh = m_fogOfWarPlane.GetComponent<MeshFilter>().mesh;
        m_vertices = m_mesh.vertices;
        m_colors = new Color[m_vertices.Length];
        for (int i = 0; i < m_colors.Length; i++)
        {
            m_colors[i] = Color.black;
        }
        UpdateColor();
    }

    void UpdateColor()
    {
        m_mesh.colors = m_colors;
    }

    public void PowerUp(string Player)
    {
        if (Player == "Player1")
        {
            m_radius1 += 2f;
        }
        else if (Player == "Player2")
        {
            m_radius2 += 2f;
        }
    }
}
