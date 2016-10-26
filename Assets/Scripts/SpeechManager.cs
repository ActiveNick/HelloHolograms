using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class SpeechManager : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer = null;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    // Use this for initialization
    void Start()
    {
        keywords.Add("Pickup Mode", () =>
        {
            // Broadcasts the message to switch to Pickup mode
            this.BroadcastMessage("OnPickup");
        });

        keywords.Add("Shooting Mode", () =>
        {
            // Broadcasts the message to switch to Shooting mode
            this.BroadcastMessage("OnShoot");
        });

        keywords.Add("Display Mesh", () =>
        {
            // Tells the SpatialMapping descendant object to display the mesh
            this.BroadcastMessage("OnDisplayMesh");
        });

        keywords.Add("Hide Mesh", () =>
        {
            // Tells the SpatialMapping descendant object to turn off the mesh
            this.BroadcastMessage("OnHideMesh");
        });

        // Tell the KeywordRecognizer about our keywords.
        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());

        // Register a callback for the KeywordRecognizer and start recognizing!
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();
    }

    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;
        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }
}