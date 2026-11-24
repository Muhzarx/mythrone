#if UNITY_EDITOR
using UnityEditor; using UnityEngine; using Mythrone.Heroes;
namespace Mythrone.EditorTools {
 public static class HeroRosterBuilder {
  [MenuItem("MYTHRONE/Generate Original Hero Roster")]
  public static void Generate(){
   string folder="Assets/MYTHRONE/ScriptableObjects/Heroes";if(!AssetDatabase.IsValidFolder(folder))System.IO.Directory.CreateDirectory(folder);
   var data=new (string,HeroRole,float,float,float,float,Color)[]{
    ("VARGAN",HeroRole.Tank,1100,52,42,4.5f,new Color(.3f,.55f,.8f)),
    ("NYXARA",HeroRole.Assassin,650,88,18,6.2f,new Color(.55f,.25f,.8f)),
    ("IGNIS",HeroRole.Mage,690,76,20,5.1f,new Color(1f,.35f,.12f)),
    ("LYRA",HeroRole.Marksman,640,82,16,5.4f,new Color(.9f,.75f,.3f)),
    ("AUREL",HeroRole.Support,800,48,28,5f,new Color(.35f,.85f,.75f)),
    ("DRAKON",HeroRole.Fighter,900,72,30,5.2f,new Color(.8f,.25f,.18f)),
    ("SERAPHINE",HeroRole.Mage,700,78,19,5.0f,new Color(.8f,.55f,.9f)),
    ("KAEL",HeroRole.Fighter,920,70,31,5.3f,new Color(.35f,.7f,.4f)),
    ("MORRIGAN",HeroRole.Assassin,660,90,17,6.1f,new Color(.45f,.3f,.55f)),
    ("BRONT",HeroRole.Tank,1200,48,45,4.3f,new Color(.55f,.5f,.35f))
   };
   foreach(var d in data){string path=folder+"/"+d.Item1+".asset";var a=AssetDatabase.LoadAssetAtPath<HeroDefinition>(path);if(!a){a=ScriptableObject.CreateInstance<HeroDefinition>();AssetDatabase.CreateAsset(a,path);}a.heroName=d.Item1;a.role=d.Item2;a.maxHealth=d.Item3;a.attackDamage=d.Item4;a.defense=d.Item5;a.moveSpeed=d.Item6;a.accentColor=d.Item7;a.fantasy="Original MYTHRONE champion. Art/model is a placeholder until a rigged character asset is authored.";EditorUtility.SetDirty(a);}
   AssetDatabase.SaveAssets();AssetDatabase.Refresh();Debug.Log("Generated 10 MYTHRONE hero definitions.");
  }
 }
}
#endif