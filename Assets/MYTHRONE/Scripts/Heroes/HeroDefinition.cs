using UnityEngine;
namespace Mythrone.Heroes {
 public enum HeroRole { Tank, Assassin, Mage, Marksman, Support, Fighter }
 [CreateAssetMenu(menuName="MYTHRONE/Hero Definition")]
 public class HeroDefinition : ScriptableObject {
  public string heroName; public HeroRole role;
  [TextArea] public string fantasy; 
  public float maxHealth=650, attackDamage=58, defense=24, moveSpeed=5.2f, attackRange=2.2f, attackCooldown=1.1f;
  public Color accentColor=Color.cyan;
  public string[] abilities = new string[4] {"Ability I","Ability II","Ability III","Ultimate"};
 }
}