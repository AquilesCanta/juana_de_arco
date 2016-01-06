#pragma strict

private var animator:Animator;

enum State{IDLE,
		   UP,
		   DOWN,
		   LEFT,
		   RIGHT,
		   DOWN_A,
		   UP_A,
		   RIGHT_A,
		   LEFT_A,
		   DOWN_B,
		   UP_B,
		   LEFT_B,
		   RIGHT_B,
		   UP_AB,
		   DOWN_AB,
		   LEFT_AB,
		   RIGHT_AB
		   }

var lastState:State;

var state:State;

function Start () {
	animator =  gameObject.GetComponent(Animator);
}

function Update(){
	if(Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.B)){
		animator.SetInteger("state",State.UP_AB);
		return;
	} else {
	if(Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.B)){
		animator.SetInteger("state",State.DOWN_AB);
		return;
	} else {
	if(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.B)){
		animator.SetInteger("state",State.LEFT_AB);
		return;
	} else {
	if(Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.B)){
		animator.SetInteger("state",State.RIGHT_AB);
		return;
	} else {
	if(Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.A)){
		animator.SetInteger("state",State.UP_A);
		return;
	} else {
	if(Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.B)){
		animator.SetInteger("state",State.UP_B);
		return;
	}else{
	if(Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.A)){
		animator.SetInteger("state",State.DOWN_A);
		return;
	} else {
	if(Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.B)){
		animator.SetInteger("state",State.DOWN_B);
		return;
	} else {
	if(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.A)){
		animator.SetInteger("state",State.LEFT_A);
		return;
	} else {
	if(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.B)){
		animator.SetInteger("state",State.LEFT_B);
		return;
	} else {
	if(Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.A)){
		animator.SetInteger("state",State.RIGHT_A);
		return;
	} else {
	if(Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.B)){
		animator.SetInteger("state",State.RIGHT_B);
		return;
	} else {
	if(Input.GetKey(KeyCode.UpArrow)){
		animator.SetInteger("state",State.UP);
		return;
	} else {
	if(Input.GetKey(KeyCode.RightArrow)){
		animator.SetInteger("state",State.RIGHT);
		return;
	} else {
	if(Input.GetKey(KeyCode.LeftArrow)){
		animator.SetInteger("state",State.LEFT);
		return;
	} else {
	if(Input.GetKey(KeyCode.DownArrow)){
		animator.SetInteger("state",State.DOWN);
		return;
	}}}}}}}}}}}}}}}}
	animator.SetInteger("state",State.IDLE);

}
