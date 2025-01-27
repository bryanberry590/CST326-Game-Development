# CST326 Game Development
 
NOTES

The following notes are from 
https://www.youtube.com/playlist?list=PLX2vGYjWbI0S9-X2Q021GUtolTqbUBB9B


ACTIVATING AND ENABLING GAME OBJECTS
- to enable or disable something such as a light, use myLight.enabled. for a toggle do myLight.enabled = !myLight.enabled;
- to activate or deactivate something in the set user gameObject.SetActive(false/true);
	-	setting a parent unactive will affect child objects by not showing them but they remain active in hierarchy.
	- myObject.activeSelf() will show in debug if object is active or not


TRANSLATE AND ROTATE
- transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
- transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
	- vector3.up/forward are relative to the object they are being applied to


LOOKAT
-transform.LookAt(targetObject);
	- this script would be applied to the camera


DESTROY
-Destroy(otherObject);
-can be used to destroy components -> Destroy(GetComponent<component>());
	-if necesary, use Destroy(gameObject, 3f) for a 3 second delay to destory the object


GETKEY GETBUTTON
- user GetButtonDown(pushed down), GetButton(button is down/active, used for holds), GetButtonUp(button released)
-bool down = Input.GetButtonDown("Jump"/KeyCode.Space);


GETAXIS
-get key and get button return a bool
-get axis returns a float value between 1 and -1
-float x = Input.GetAxis("Horizontal")


ONMOUSEDOWN
- void OnMouseDown(){}
- can do many things such as rb.AddForce(-transform.forward * 500f) when clicking something


GETCOMPONENT
-can be used to gain access to other scripts
- in the main script, anotherScript = GetComponent<AnotherScript>(); this would go in awake function
-getcomponent is expensive in processing power so call as infrequently as possible


DELTATIME
- Update function is not smooth between frames, fixed update is


DATATYPES IN UNITY
-Value - contain a value
	int
	float
	double
	bool
	char
	Structs - contain one or more variables
		Vector3
		Quaternion
-Reference - contain a memory address where values are stored
	-Classes
		Transform
		GameObject

CLASSES
- can have class in a class and create instances of the inner class in the outer class


INSTANTIATE
-used to create clones such as in PreFabs
-used by Instantiate(ObjectToClone) Where ObjectToCLone is defined at the type as a RigidBody or an object
-or can use Instantiate(Object, position, rotation)
-Instantiate returns an object, can cast to RigidBody by using 
            Rigidbody rocketInstance;
            rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            rocketInstance.AddForce(barrelEnd.forward * 5000);
- Consider Destroying objects such as bullets after x amount of time


ARRAYS
-int[] myIntArray = new int[numElements];
-int[] myArray = {1,2,3,4,5};
-can initialize in Start function
-myArray.Length
-can have arrays of GameObjects instantiated the same.


INVOKE
-allows for function calls after a specified amount of time
- in start function, Invoke("name of method to call", int that represents number of second till method call)
- can use InvokeRepeating("method to call", delay till initial call int, delay between each subsequent call)
-can user CancelInvoke("MethodName")


ENUMERATION
-special data type with a specific subset of values
- enum Direction {North, East, South, West}; example
- to access enum, Direction myDirection = Direction.North/South/East/West 


SWITCH STATEMENTS
-a more streamlined conditional 
-common use is to make decisions based on enums
- Switch Example: 
    
    public int intelligence = 5;

    void Greet()
    {
        switch (intelligence)
        {
        case 5:
            print ("Why hello there good sir! Let me teach you about Trigonometry!");
            break;
        case 4:
            print ("Hello and good day!");
            break;
        case 3:
            print ("Whadya want?");
            break;
        case 2:
            print ("Grog SMASH!");
            break;
        case 1:
            print ("Ulg, glib, Pblblblblb");
            break;
        default:
            print ("Incorrect intelligence level.");
            break;
        }
    }







