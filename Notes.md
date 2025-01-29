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

The following notes are from https://www.youtube.com/playlist?list=PLX2vGYjWbI0RCmCHa3dDKblhJPpW9ZXnu

COLLIDERS
- can be sphere, capsule, box/cube
- for complex objects use multiple of the above or a mesh collider
- when there is a collision, a method called OnCollisionEnter is called
- in a script use, OnCollisionEnter, OnCollisionStay, OnCollisionExit

COLLIDERS AS TRIGGERS
- check the is trigger check box in the collider component
- things will pass through the trigger collider object (invisible box to check for a collision)
- in a script use, OnTriggerEnter, OnTriggerStay, OnTriggerExit
- typically triggers are static
- needs to be collided by a rigidbody object

RIGIDBODIES
- If there is a moving object, it should be rigidbody
- rigidbodies allow for physics on objects
- required for physics on objects and needs a collider 
- component box has isGravity option
- use kinematic for pong ball or paddle
- kinematics can be moved using the transform function

ADDFORCE
- adds force to a physics object
- has one required parameter, a vector 3 that represents direction and magnitude
- optional parameter is ForceMode Acceleration/force/impulse/velocityChange

ADDTORQUE
- similar to addforce but instead applies force to rotate an object around a specific axis
- required parameter is a direction such as transform.up
- optional parameter is ForceMode Acceleration/force/impulse/velocityChange

PHYSICS MATERIALS
- can be created in the project panel
- dynamic friction is how much friciton exists while object is moving
- static friction is how much force is required to move the object from a static position

JOINTS
- fixed joints lock an object in place
- spring joints are connected to one pivot point. any rigidbodies attached to the other end will make them move.
- hinge joints are ideal for things like doors
 - the axis of the hinge is where it will rotate around, like a door.

RAYCASTING
- used for things like shooting guns
- Physics.Raycast(Vector3 origin (typically a gun barrel), Vector3 direction, RaycastHit hitInfo (checks for object that are hit by the raycast), *optional* float distance (the length of the ray), int LayerMask (can place objects that you want the ray to ignore))
- use Debug.DrawRay(parameters look up) to draw a ray for debug purposes

DETECTING COLLISIONS
- one of the two colliding objects needs a OnCollisionEnter(Collision variable)
- you can do things in this function on collision such as Destroy(variable.?)




TRANSLATE VS RIGIDBODY from https://www.youtube.com/watch?v=ixM2W2tPn6c
- translate
    - translate is the easiest to setup
    - create a move function with a vector position parameter. in the function, transform.translate(direction * time.deltatime * speed)
    - no collision detection, overrides unity physics, better used for animation without physics

- rigidbody
    - setup same as translate but create a public rigidbody variable at the top of the class
    - define rb in start method
    - use fixedupdate method instead of update because of the use of physics
    - rb.Addforcs, rb.velocity, rb.movePosition






