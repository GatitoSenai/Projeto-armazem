using UnityEngine;

public class SpecializedUnit : Unit
{
    //New variables
    private ResourcePile m_currentpile = null;
    public float ProductivityMultiplier = 2;
    protected override void BuildingInRange()
    {   
        if (m_currentpile == null)
        {
            ResourcePile pile = m_Target as ResourcePile;

            if (pile != null)
            {
                m_currentpile = pile;
                m_currentpile.ProductionSpeed *= ProductivityMultiplier;
            }
        }
    }
    public override string GetName()
    {
        return "Enzo Gads";
    }
}
