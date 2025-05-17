using UnityEngine;

public class Enemy : MonoBehaviour, IInteraction
{
    [SerializeField] private ScriptableEnemy EnemyData;
    
    private string EnemyName;
    private float Damage;
    private float Health;

    private void Start()
    {
        EnemyName = EnemyData.GSEnemyName;
        Damage = EnemyData.GSDamage;
        Health = EnemyData.GSHealth;
    }

    public void Interact()
    {
        EnemyData.PrintData();
    }
}
