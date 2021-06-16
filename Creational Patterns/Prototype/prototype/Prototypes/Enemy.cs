namespace prototype.Prototypes
{
    public abstract class Enemy
    {
        int m_Health;
        int m_Attck;
        double m_Damage;
        EnemeyTrait m_EnemyTrait = new EnemeyTrait();

        public int Health
        {
            get { return m_Health; }
            set { m_Health = value; }
        }

        public int Attack
        {
            get { return m_Attck; }
            set { m_Attck = value; }
        }

        public double Damage
        {
            get { return m_Damage; }
            set { m_Damage = value; }
        }

        public EnemeyTrait EnemeyTrait
        {
            get { return m_EnemyTrait; }
            set { m_EnemyTrait = value; }
        }

        public abstract Enemy Clone();
    }
}