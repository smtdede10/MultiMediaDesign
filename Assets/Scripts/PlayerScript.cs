using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript: MonoBehaviour {
	
	public GUITexture ItemsGuiTexture;
	public GameObject activeObject;
	public GUIText guiInfo;
	public GameObject takableObject1,takableObject2,takableObject3,takableObject4;
	public Texture t1,t2,t3,t4;
	
	public GUITexture GT1,GT2,GT3,GT4;
	GUITexture[] GTList;
	
	bool[] isTaked;
	int[] showsObj;
	int index;
	
	Vector2[] itemCases;
	GameObject[] objectCases;
	char[] controls;
	
	Texture[] takableObjectsTextures;
	GameObject[] takableObjects;
	Ray ray;
	RaycastHit hit;
	
	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
		GT1.enabled = false;
		GT2.enabled = false;
		GT3.enabled = false;
		GT4.enabled = false;
		
		isTaked = new bool[6]{false,false,false,false,false,false};
		showsObj = new int[6]{6,6,6,6,6,6};

		
		takableObjects = new GameObject[4]{takableObject1,takableObject2,takableObject3,takableObject4};
		takableObjectsTextures = new Texture[4]{t1,t2,t3,t4};
		
		itemCases=new Vector2[6];

		itemCases [3] = new Vector2 (0,0);
		itemCases [4] = new Vector2 (0,ItemsGuiTexture.pixelInset.width/3);
		itemCases [5] = new Vector2 (0,2*(ItemsGuiTexture.pixelInset.width/3));
		
		itemCases [0] = new Vector2 (ItemsGuiTexture.pixelInset.height/2,0);
		itemCases [1] = new Vector2 (ItemsGuiTexture.pixelInset.height/2,ItemsGuiTexture.pixelInset.width/2);
		itemCases [2] = new Vector2 (ItemsGuiTexture.pixelInset.height/2,2*(ItemsGuiTexture.pixelInset.width/2));


		/*
		itemCases [3] = new Vector2 (-ItemsGuiTexture.pixelInset.x,-ItemsGuiTexture.pixelInset.y);
		itemCases [4] = new Vector2 (-ItemsGuiTexture.pixelInset.x,-ItemsGuiTexture.pixelInset.y+ItemsGuiTexture.pixelInset.width/3);
		itemCases [5] = new Vector2 (-ItemsGuiTexture.pixelInset.x,-ItemsGuiTexture.pixelInset.y+2*(ItemsGuiTexture.pixelInset.width/3));
		
		itemCases [0] = new Vector2 (-ItemsGuiTexture.pixelInset.x+ItemsGuiTexture.pixelInset.height/2,-ItemsGuiTexture.pixelInset.y);
		itemCases [1] = new Vector2 (-ItemsGuiTexture.pixelInset.x+ItemsGuiTexture.pixelInset.height/2,-ItemsGuiTexture.pixelInset.y+ItemsGuiTexture.pixelInset.width/3);
		itemCases [2] = new Vector2 (-ItemsGuiTexture.pixelInset.x+ItemsGuiTexture.pixelInset.height/2,-ItemsGuiTexture.pixelInset.y+2*(ItemsGuiTexture.pixelInset.width/3));
		*/
		objectCases = new GameObject[6]{null,null,null,null,null,null};
		controls = new char[6]{'Q','W','E','R','T','Y'};
		
		GTList = new GUITexture[4]{GT1,GT2,GT3,GT4};
		
		index=0;
//		print (itemCases [1].x+" "+itemCases [1].y);
		
	}
	
	
	
	IEnumerator SetItem() {
		for(int j=0;j<6;j++){
			if(!isTaked[j])
			{
				isTaked[j]=true;
				GTList[index].pixelInset=new Rect(itemCases[j].y+315,itemCases[j].x-225,50,50);
				GTList[index].enabled=true;
				takableObjects[index].SetActive(false);


				switch(index){

				case 0:
					takableObject1.GetComponent<lambtreat>().active=true;
					break;




				}
				showsObj[j]=index;
				
				break;
				
			}
		}yield return new WaitForSeconds(.5f);
	}
	
	
	

	
	
	
	
	
	
	// Update is called once per frame
	void Update () {
		ray = Camera.main.ScreenPointToRay (new Vector3 (Screen.width/2,Screen.height/2,0));
	
		
		
		
		
		
	
				
				
				if(Input.GetKeyDown (KeyCode.E)){

					switch(showsObj[0])
					{

					case 0:
						GTList [0].enabled = false;
						takableObject1.renderer.enabled=true;
						takableObject1.SetActive(true);
						takableObject1.transform.position=transform.position+new Vector3(2,2,2);
						isTaked[0]=false;

						break;


					case 1:

						GTList [1].enabled = false;
						takableObject2.renderer.enabled=true;
						takableObject2.SetActive(true);
						isTaked[0]=false;

						if (Physics.Raycast ( ray,out hit, 10f)){
					//takableObject2.transform.localPosition= transform.position;

					takableObject2.transform.localPosition = new Vector3(9.35f,0.1202534f,-1.72f);
				//	takableObject2.transform.rotate = 
						//takableObject2.transform.Rotate(0,0,Space.Self);

					}
						break;


					case 2:

						GTList [2].enabled = false;
						takableObject3.renderer.enabled=true;
						takableObject3.SetActive(true);
						isTaked[0]=false;

						takableObject3.transform.position=transform.position;


						if (Physics.Raycast ( ray,out hit, 10f)){
							
							if(hit.transform.name=="doors2")
					{print("Oyun Bitti");
						Application.LoadLevel("Finish");}
							
						}

						break;


					case 3:

						GTList [3].enabled = false;
						takableObject4.renderer.enabled=true;
						takableObject4.SetActive(true);
						isTaked[0]=false;








						break;







					}

					isTaked[0]=false;

					/*

					if( showsObj[i]==0)
					{
						GTList [0].enabled = false;
						takableObject1.renderer.enabled=true;
						takableObject1.SetActive(true);
						takableObject1.transform.position=transform.position+new Vector3(2,2,2);
						isTaked[i]=false;
					}
					if( showsObj[i]==1)
					{
						GTList [1].enabled = false;
						takableObject2.renderer.enabled=true;
						takableObject2.SetActive(true);
						isTaked[i]=false;
					}
					if( showsObj[i]==2)
					{
						GTList [2].enabled = false;
						takableObject3.renderer.enabled=true;
						takableObject3.SetActive(true);
						isTaked[i]=false;
					}
					if( showsObj[i]==3)
					{
						GTList [3].enabled = false;
						takableObject4.renderer.enabled=true;
						takableObject4.SetActive(true);
						isTaked[i]=false;
					}
					else{isTaked[i]=false;}
					
				*/
					
				}
				
				
				if(Input.GetKeyDown (KeyCode.R)){



			switch(showsObj[1])
			{
				
			case 0:
				GTList [0].enabled = false;
				takableObject1.renderer.enabled=true;
				takableObject1.SetActive(true);
				takableObject1.transform.position=transform.position+new Vector3(2,2,2);
				isTaked[1]=false;
				
				break;
				
				
			case 1:
				
				GTList [1].enabled = false;
				takableObject2.renderer.enabled=true;
				takableObject2.SetActive(true);
				isTaked[1]=false;
				
				if (Physics.Raycast ( ray,out hit, 10f)){
					takableObject2.transform.localPosition = new Vector3(9.35f,0.1202534f,-1.72f);
					//	takableObject2.transform.localPosition=hit.transform.localPosition;
					//		takableObject2.transform.Rotate(0,0,Space.Self);
				}
				break;
				
				
			case 2:
				
				GTList [2].enabled = false;
				takableObject3.renderer.enabled=true;
				takableObject3.SetActive(true);
				isTaked[1]=false;

				takableObject3.transform.position=transform.position;
				
				
				if (Physics.Raycast ( ray,out hit, 10f)){
					
					if(hit.transform.name=="doors2")
					{print("Oyun Bitti");
						Application.LoadLevel("Finish");}
					
				}
				
				break;
				
				
			case 3:
				
				GTList [3].enabled = false;
				takableObject4.renderer.enabled=true;
				takableObject4.SetActive(true);
				isTaked[1]=false;

				
				break;
				
				
				
				
				
				
				
			}
			
			isTaked[1]=false;





			/*
					
					if( showsObj[i]==0)
					{
						GTList [0].enabled = false;
						takableObject1.renderer.enabled=true;
						takableObject1.SetActive(true);
						takableObject1.transform.position=transform.position+new Vector3(2,2,2);
						isTaked[i]=false;
					}
					else if( showsObj[i]==1)
					{
						GTList [1].enabled = false;
						takableObject2.renderer.enabled=true;
						takableObject2.SetActive(true);
						isTaked[i]=false;
					}
					else if( showsObj[i]==2)
					{
						GTList [2].enabled = false;
						takableObject3.renderer.enabled=true;
						takableObject3.SetActive(true);
						isTaked[i]=false;
					}
					else if( showsObj[i]==3)
					{
						GTList [3].enabled = false;
						takableObject4.renderer.enabled=true;
						takableObject4.SetActive(true);
						isTaked[i]=false;
					}
					else{isTaked[i]=false;}*/



					
				}
				
				
				
				
				if(Input.GetKeyDown (KeyCode.T)){
				
			switch(showsObj[2])
			{
				
			case 0:
				GTList [0].enabled = false;
				takableObject1.renderer.enabled=true;
				takableObject1.SetActive(true);
				takableObject1.transform.position=transform.position+new Vector3(2,2,2);
				isTaked[2]=false;
				
				break;
				
				
			case 1:
				
				GTList [1].enabled = false;
				takableObject2.renderer.enabled=true;
				takableObject2.SetActive(true);
				isTaked[2]=false;
				
				if (Physics.Raycast ( ray,out hit, 10f)){
					takableObject2.transform.localPosition = new Vector3(9.35f,0.1202534f,-1.72f);
					//	takableObject2.transform.localPosition=hit.transform.localPosition;
					//		takableObject2.transform.Rotate(0,0,Space.Self);
				}
				break;
				
				
			case 2:
				
				GTList [2].enabled = false;
				takableObject3.renderer.enabled=true;
				takableObject3.SetActive(true);
				isTaked[2]=false;

				takableObject3.transform.position=transform.position;
				
				
				if (Physics.Raycast ( ray,out hit, 10f)){
					
					if(hit.transform.name=="doors2")
					{print("Oyun Bitti");
						Application.LoadLevel("Finish");}
					
				}
				
				break;
				
				
			case 3:
				
				GTList [3].enabled = false;
				takableObject4.renderer.enabled=true;
				takableObject4.SetActive(true);
				isTaked[2]=false;

				
				break;
				
				
				
				
				
				
				
			}
			
			isTaked[2]=false;






			/*
					if( showsObj[i]==0)
					{
						GTList [0].enabled = false;
						takableObject1.renderer.enabled=true;
						takableObject1.SetActive(true);
						takableObject1.transform.position=transform.position+new Vector3(2,2,2);
						isTaked[i]=false;
					}
					if( showsObj[i]==1)
					{
						GTList [1].enabled = false;
						takableObject2.renderer.enabled=true;
						takableObject2.SetActive(true);
						isTaked[i]=false;
					}
					if( showsObj[i]==2)
					{
						GTList [2].enabled = false;
						takableObject3.renderer.enabled=true;
						takableObject3.SetActive(true);
						isTaked[i]=false;
					}
					if( showsObj[i]==3)
					{
						GTList [3].enabled = false;
						takableObject4.renderer.enabled=true;
						takableObject4.SetActive(true);
						isTaked[i]=false;
					}
					else{isTaked[i]=false;}*/


				}
				
				
				
				if(Input.GetKeyDown (KeyCode.Y)){
					
			switch(showsObj[3])
			{
				
			case 0:
				GTList [0].enabled = false;
				takableObject1.renderer.enabled=true;
				takableObject1.SetActive(true);
				takableObject1.transform.position=transform.position+new Vector3(2,2,2);
				isTaked[3]=false;
				
				break;
				
				
			case 1:
				
				GTList [1].enabled = false;
				takableObject2.renderer.enabled=true;
				takableObject2.SetActive(true);
				isTaked[3]=false;
				
				if (Physics.Raycast ( ray,out hit, 10f)){
					takableObject2.transform.localPosition = new Vector3(9.35f,0.1202534f,-1.72f);
					//	takableObject2.transform.localPosition=hit.transform.localPosition;
					//		takableObject2.transform.Rotate(0,0,Space.Self);
				}
				break;
				
				
			case 2:
				
				GTList [2].enabled = false;
				takableObject3.renderer.enabled=true;
				takableObject3.SetActive(true);
				isTaked[3]=false;

				takableObject3.transform.position=transform.position;
				
				
				if (Physics.Raycast ( ray,out hit, 10f)){
					
					if(hit.transform.name=="doors2")
					{print("Oyun Bitti");
						Application.LoadLevel("Finish");}
					
				}
				
				break;
				
				
			case 3:
				
				GTList [3].enabled = false;
				takableObject4.renderer.enabled=true;
				takableObject4.SetActive(true);
				isTaked[3]=false;


				
				break;
				
				
				
				
				
				
				
			}
			
			isTaked[3]=false;






			/*
					if( showsObj[i]==0)
					{
						GTList [0].enabled = false;
						takableObject1.renderer.enabled=true;
						takableObject1.SetActive(true);
						takableObject1.transform.position=transform.position+new Vector3(2,2,2);
						isTaked[i]=false;
					}
					if( showsObj[i]==1)
					{
						GTList [1].enabled = false;
						takableObject2.renderer.enabled=true;
						takableObject2.SetActive(true);
						isTaked[i]=false;
					}
					if( showsObj[i]==2)
					{
						GTList [2].enabled = false;
						takableObject3.renderer.enabled=true;
						takableObject3.SetActive(true);
						isTaked[i]=false;
					}
					if( showsObj[i]==3)
					{
						GTList [3].enabled = false;
						takableObject4.renderer.enabled=true;
						takableObject4.SetActive(true);
						isTaked[i]=false;
					}
					else{isTaked[i]=false;}*/
					
				}
				
				
				
				if(Input.GetKeyDown (KeyCode.U)){
					
			switch(showsObj[4])
			{
				
			case 0:
				GTList [0].enabled = false;
				takableObject1.renderer.enabled=true;
				takableObject1.SetActive(true);
				takableObject1.transform.position=transform.position+new Vector3(2,2,2);
				isTaked[4]=false;
				
				break;
				
				
			case 1:
				
				GTList [1].enabled = false;
				takableObject2.renderer.enabled=true;
				takableObject2.SetActive(true);
				isTaked[4]=false;
				
				if (Physics.Raycast ( ray,out hit, 10f)){
					takableObject2.transform.localPosition = new Vector3(9.35f,0.1202534f,-1.72f);
					//	takableObject2.transform.localPosition=hit.transform.localPosition;
					//		takableObject2.transform.Rotate(0,0,Space.Self);
				}
				break;
				
				
			case 2:
				
				GTList [2].enabled = false;
				takableObject3.renderer.enabled=true;
				takableObject3.SetActive(true);
				isTaked[4]=false;

				takableObject3.transform.position=transform.position;
				
				
				if (Physics.Raycast ( ray,out hit, 10f)){
					
					if(hit.transform.name=="doors2")
					{print("Oyun Bitti");
						Application.LoadLevel("Finish");}
					
				}
				
				break;
				
				
			case 3:
				
				GTList [3].enabled = false;
				takableObject4.renderer.enabled=true;
				takableObject4.SetActive(true);
				isTaked[4]=false;

			
				
				break;
				
				
				
				
				
				
				
			}
			
			isTaked[4]=false;




			/*
					if( showsObj[i]==0)
					{
						GTList [0].enabled = false;
						takableObject1.renderer.enabled=true;
						takableObject1.SetActive(true);
						takableObject1.transform.position=transform.position+new Vector3(2,2,2);
						isTaked[i]=false;
					}
					if( showsObj[i]==1)
					{
						GTList [1].enabled = false;
						takableObject2.renderer.enabled=true;
						takableObject2.SetActive(true);
						isTaked[i]=false;
					}
					if( showsObj[i]==2)
					{
						GTList [2].enabled = false;
						takableObject3.renderer.enabled=true;
						takableObject3.SetActive(true);
						isTaked[i]=false;
					}
					if( showsObj[i]==3)
					{
						GTList [3].enabled = false;
						takableObject4.renderer.enabled=true;
						takableObject4.SetActive(true);
						isTaked[i]=false;
					}
					else{isTaked[i]=false;}*/



					
				}
				
				
				
				if(Input.GetKeyDown (KeyCode.I)){
				
			switch(showsObj[5])
			{
				
			case 0:
				GTList [0].enabled = false;
				takableObject1.renderer.enabled=true;
				takableObject1.SetActive(true);
				takableObject1.transform.position=transform.position+new Vector3(2,2,2);
				isTaked[5]=false;
				
				break;
				
				
			case 1:
				
				GTList [1].enabled = false;
				takableObject2.renderer.enabled=true;
				takableObject2.SetActive(true);
				isTaked[5]=false;
				
				if (Physics.Raycast ( ray,out hit, 10f)){
					takableObject2.transform.localPosition = new Vector3(9.35f,0.1202534f,-1.72f);
					//	takableObject2.transform.localPosition=hit.transform.localPosition;
					//		takableObject2.transform.Rotate(0,0,Space.Self);
				}
				break;
				
				
			case 2:
				
				GTList [2].enabled = false;
				takableObject3.renderer.enabled=true;
				takableObject3.SetActive(true);
				isTaked[5]=false;

				takableObject3.transform.position=transform.position;
				
				
				if (Physics.Raycast ( ray,out hit, 10f)){
					
					if(hit.transform.name=="doors2")
					{print("Oyun Bitti");
					Application.LoadLevel("Finish");}
					
				}
				
				break;
				
				
			case 3:
				
				GTList [3].enabled = false;
				takableObject4.renderer.enabled=true;
				takableObject4.SetActive(true);
				isTaked[5]=false;

				
				break;
				
				
				
				
				
				
				
			}
			
			isTaked[5]=false;






			/*
					if( showsObj[i]==0)
					{
						GTList [0].enabled = false;
						takableObject1.renderer.enabled=true;
						takableObject1.SetActive(true);
						takableObject1.transform.position=transform.position+new Vector3(2,2,2);
						isTaked[i]=false;
					}
					if( showsObj[i]==1)
					{
						GTList [1].enabled = false;
						takableObject2.renderer.enabled=true;
						takableObject2.SetActive(true);
						isTaked[i]=false;
					}
					if( showsObj[i]==2)
					{
						GTList [2].enabled = false;
						takableObject3.renderer.enabled=true;
						takableObject3.SetActive(true);
						isTaked[i]=false;
					}
					if( showsObj[i]==3)
					{
						GTList [3].enabled = false;
						takableObject4.renderer.enabled=true;
						takableObject4.SetActive(true);
						isTaked[i]=false;
					}
					else{isTaked[i]=false;}*/


					
				}
				
				
				

			
		
		
		
		
		
		
		if (Physics.Raycast ( ray,out hit, 10f)) {
			print(hit.transform.name);
			
			if (Input.GetKeyDown (KeyCode.F)) {
				
				
				
				for(int i=0;i<4; i++)
				{
					
					if(takableObjects[i]!=null && hit.transform.name==takableObjects[i].transform.name)
					{
						print(hit.transform.name+" "+takableObjects[i].transform.name);
						print(hit.transform.name+"=="+takableObjects[i].transform.name);
						print("Sorgulanan index:"+i);
						index=i;
						StartCoroutine("SetItem");
						
						
						
					}
				}
			}
		}
		
		
		

		Debug.DrawRay(transform.position,ray.direction*10,Color.green);
		
		
		if (Physics.Raycast ( ray,out hit, 10f)) {
			
			if (  hit.transform.name == "takableObj2" )
				guiInfo.text = "Merdiveni almak için 'F' tuşuna basın..";
			else	
				if (  hit.transform.name == "takableObj1" )
					
					guiInfo.text = "Gaz lambasını almak için 'F' tuşuna basın..";
			else
				if (  hit.transform.name == "takableObj3" )
					
					guiInfo.text = "Anahtarı almak için 'F' tuşuna basın..";
			else
				if (  hit.transform.name == "pervane"||hit.transform.name == "yuva" )
					
					guiInfo.text = "Fanı durdurmak için stop butonuna basmalısın..";
			else
				if (  hit.transform.name == "BodrumWall1" )
					
					guiInfo.text = "Çok karanlık, bence gaz lambasını kullanmalısın..";
			else

				if (  hit.transform.name == "doors2" )
					
					guiInfo.text = "Tek çıkış yolu bu kapı. Anahtarı bulmalısın..";
			else
				if (  hit.transform.name == "Stop" )
					
					guiInfo.text = "Pervaneyi durdurmak için 'F' tuşuna bas.";
			else
				if (  hit.transform.name == "Start" )
					
					guiInfo.text = "Pervaneyi çalıştırmak için 'F' tuşuna bas.";
			else


				guiInfo.text="";
			
		}
		
		
	}
}
