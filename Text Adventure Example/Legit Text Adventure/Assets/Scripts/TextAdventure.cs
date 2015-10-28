using UnityEngine;
using System.Collections;

public class TextAdventure : MonoBehaviour {

	public string currentRoom = "entryway";
	public Camera myCamera;

	[Header("Audio stuff")]

	public AudioSource bgm;
	public AudioClip bgm_win;

	public AudioSource sfx;
	public AudioClip sfx_keyGet;
	public AudioClip sfx_partyHorn;


	[Header("rooms")]
	public string room_north;
	public string room_south;
	public string room_east;
	public string room_west;

	private int currentExperience = 0;
	private int expToLevel = 10;
	private int level = 0;

	private bool hasKey = false;

	private bool monsterExists = false;

	private bool roomEntered = false;

	private bool won = false;

	// Use this for initialization
	void Start () {



		
	}
	
	// Update is called once per frame
	void Update () {
		string textBuffer = "";
		room_north = "";
		room_south = "";
		room_west = "";
		room_east = "";

		switch (currentRoom)
		{
		case "entryway":
			textBuffer = "You are in the entryway.\n";

			if (!roomEntered)
			{
				float randomizer;
				randomizer = Random.Range(0,1.0f);
				Debug.Log (randomizer);
				
				if (randomizer > 0.5f)
				{
					monsterExists = true;
				}

			}

			if (monsterExists)
			{
				textBuffer += "There's a monster.\n";
			}

			room_north = "magicRoom";

			roomEntered = true;

			break;
		case "magicRoom":

			myCamera.backgroundColor = Color.magenta;

			textBuffer = "You are in the magic room.\n";

			room_south = "entryway";
			room_west = "key room";
			room_east = "partyRoom";
			break;
		case "key room":
			textBuffer = "You are in a room, that's called \n" +
				"the key room, for some reason.\n" +
				"There is a drawer in front of you.\n" +
				"Press 'm' to open the drawer....\n" +
					"with your MIND";

			if (Input.GetKeyDown(KeyCode.M))
			{
				currentRoom = "got key";
			}

			room_east = "magicRoom";

			break;
		case "got key":
			textBuffer = "Congratulations. You opened \n" +
				"the drawer with your mind, and found, inside,\n" +
				"a snake. And you cut the snake open, which\n" +
					"is disgusting, but at least you found this key.\n" +
					"leave. (press any key)";

			if (!hasKey)
			{
				hasKey = true;
				sfx.clip = sfx_keyGet;
				sfx.Play();
			}

			if (Input.anyKeyDown)
			{
				currentRoom = "key room";
			}
					
			break;
		case "partyRoom":
			textBuffer = "You are in the partyRoom.\n";

			room_west = "magicRoom";
			room_east = "party room door";
			break;
		case "party room door":
			if (hasKey)
			{
				textBuffer = "you use the key to open the door";

				room_south = "after party room";
			} else {

				textBuffer = "The door is locked. \nPress any key to return to the party room.";

				if (Input.anyKeyDown)
				{
					currentRoom = "partyRoom";
				}

			}

			break;
		case "after party room":
			textBuffer = "You are in the after party room.\n" +
				"all of your friends are here.\n" +
					"you won.";
	

			if (!won)
			{
				sfx.volume = .5f;
				sfx.PlayOneShot(sfx_partyHorn);
				won = true;
			}

			bgm.clip = bgm_win;
			if(!bgm.isPlaying)
			{
				bgm.Play ();
			}


			break;
		default:
			break;

		}

		if (room_north != "")
		{
			textBuffer += "\nPress 'n' to go to the " + room_north + ".";

			if(Input.GetKeyDown(KeyCode.N))
			{
				currentRoom = room_north;
				currentExperience += 1;

				if (currentExperience >= expToLevel)
				{
					level += 1;
				
					currentExperience = 0;
				}
				roomEntered = false;
			}

		}
		if (room_south != "")
		{
			textBuffer += "\nPress 's' to go to the " + room_south + ".";
			
			if(Input.GetKeyDown(KeyCode.S))
			{
				currentRoom = room_south;
				roomEntered = false;
			}
		}
		if (room_east != "")
		{
			textBuffer += "\nPress 'e' to go to the " + room_east + ".";
			
			if(Input.GetKeyDown(KeyCode.E))
			{
				currentRoom = room_east;
				roomEntered = false;
			}
		}
		if (room_west != "")
		{
			textBuffer += "\nPress 'w' to go to the " + room_west + ".";
			
			if(Input.GetKeyDown(KeyCode.W))
			{
				currentRoom = room_west;
				roomEntered = false;
			}
		}


		GetComponent<TextMesh>().text = textBuffer;

	}
}
