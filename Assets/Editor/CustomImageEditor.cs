using UnityEditor;

[CustomEditor(typeof(CustomImage))]
public class CustomImageEditor : Editor
{
    public override void OnInspectorGUI()
    {
        // ��s�ǦC�ƪ���
        serializedObject.Update();

        // ���Image���w�]Inspector���O
        base.OnInspectorGUI();

        // ���ΩҦ����ק�
        serializedObject.ApplyModifiedProperties();
    }
}
