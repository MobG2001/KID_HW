using UnityEngine;
namespace MobG
{
    /// <summary>
    /// 對話資料
    /// </summary>
    [CreateAssetMenu(menuName = "MobG/Dialogue Data", fileName = "New Dialogue Data")]
    public class DialogueData : ScriptableObject
    {
        [Header("對話者名稱")]
        public string dialogueName;
        [Header("對話者名稱"), TextArea(2, 10)]
        public string[] dialogueContents;
    }
}
