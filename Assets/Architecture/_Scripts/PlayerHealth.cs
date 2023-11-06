using UnityEditor;
using UnityEngine;

namespace Mario.Assets.Architecture._Scripts
{
    public class PlayerHealth
    {
        private int _bonusHealth;
        private int _hp = new Player().Health;
        private int _maxHp = new Player().MaxHealth;
        

        private void SetHealth()
        {
            _hp += _bonusHealth;
            if (_hp >= _maxHp) _hp = _maxHp;
        }

        private void TakeDamage(int damage)
        {
            _hp -= damage;
        }
    }

}

