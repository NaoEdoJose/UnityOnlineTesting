using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {

	private const string typeName = "UniqueGameNaame";
	private const string gameName  = "RoomName";
	public int maxPlayers = 2;
	public int port = 3128;

	void Start(){
		StartServer ();
	
	}

	private void StartServer(){

		Network.InitializeServer (maxPlayers, port, !Network.HavePublicAddress ());
		MasterServer.RegisterHost (typeName, gameName);
	}
	void OnServerInitialized(){

		Debug.Log("Server Initialized");
	}
}
