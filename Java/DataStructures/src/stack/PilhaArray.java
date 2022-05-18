/*
 * Author: Tonny Weslley
 * Id: 20211014040042
 * Class: Linear Data Structures
 * Date: 05/14/2022 - Saturday
 * */

package stack;

public class PilhaArray implements IPilha{

	//attributes
	private int t; // Indicates the size of the array -1 (why ? implementation choice).¯\_(ツ)_/¯.
	private int capacity; // Indicate the max capacity of the array.
	private int GF; // Indicates how the array grows when is filled.
	private Object[] array; // The instance of a default array that will be used.
	
	// !!! For reasons of simplicity, this class will not have getters and setters for the attributes.
	
	//Class constructor
	public PilhaArray (int capacity, int GF) throws PilhaVaziaException {
		// First, we need to test if the capacity complies with the parameters (capacity >= 1)
		if(capacity < 1) {
			throw new PilhaVaziaException("You can't create a stack without capacity");
		}else {
			this.t = -1; // Initiate the t attribute with -1 (why ? implementation choice).¯\_(ツ)_/¯.
			this.capacity = capacity;  // Assign capacity argument to capacity attribute.
			this.array = new Object[capacity]; // instantiate a array with the capacity and assign to the array attribute.
			
			/* Now, we need to chose the GF (growth factor).
			 * We have two methods to do it:
			 * .1 Duplicate mode (GF == 0)  - when the array is filled, we duplicate the size of the array.
			 * .2 Incremental mode (GF > 0) - when the array is filed, we increase the size of the array based on the GF.
			 * We need to avoid errors when a dumbass user put some negative value, in this case, the program will use the duplicate mode setting the GF to 0.
			 **/
			
			if(GF < 0) {
				this.GF = 0;
			}else {
				this.GF = GF;
			}
			
		}	
	} // Class constructor end
	
	
	@Override
	//This method add a value on the top of the array.
	public void push(Object o) {
		// First, we need to ensure the stack is not full
		if (this.t >= this.capacity -1){
			// If the Stack is full, we need to grow by the Growth Factor (GF)
			if(GF == 0) {
				this.capacity *= 2;
			}else {
				this.capacity += this.GF;
			}
			// Now we need to instantiate a new array with the new aspects and transfer the old values to him.
			Object newArray[] = new Object[capacity];
			for (int i = 0; i < this.array.length; i++) {
				newArray[i] = this.array[i];
			}
			// Now we can add the value to the array.
			newArray[++t] = o;
			// Then replace the old array to a new ones in the class attributes.
			this.array = newArray;
		}else {
			this.array[++t] = o;
		}
	}

	@Override
	public Object pop() throws PilhaVaziaException {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public Object top() throws PilhaVaziaException {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public boolean isEmpty() {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public int size() {
		// TODO Auto-generated method stub
		return 0;
	}

}
