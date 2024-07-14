using UnityEngine;

public class NPCText : MonoBehaviour
{
    public GameObject chatBubble;  // Reference to the chat bubble GameObject

    void Start()
    {
        // Ensure the chatBubble is initially hidden
        if (chatBubble != null)
        {
            chatBubble.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player enters the trigger
        if (other.CompareTag("Player"))
        {
            // Show the chat bubble
            if (chatBubble != null)
            {
                chatBubble.SetActive(true);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // Check if the player exits the trigger
        if (other.CompareTag("Player"))
        {
            // Hide the chat bubble
            if (chatBubble != null)
            {
                chatBubble.SetActive(false);
            }
        }
    }
}
