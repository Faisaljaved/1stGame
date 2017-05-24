using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerInput : MonoBehaviour
{
    private Player player;
    private void Start()
    {
        player = GetComponent<Player>();
    }

    private void Update()
    {
		if (Input.GetKey ("left") && Input.GetKey ("right")) {
			Vector2 directionalInput = Vector2.zero;
			player.SetDirectionalInput (directionalInput);
		} 
		else {
			Vector2 directionalInput = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));
			player.SetDirectionalInput (directionalInput);
		}

		if (Input.GetButtonUp("Jump"))
		{
			player.OnJumpInputDown();
		}

        if (Input.GetButtonUp("Jump"))
        {
            player.OnJumpInputUp();
        }
	
    }
}
