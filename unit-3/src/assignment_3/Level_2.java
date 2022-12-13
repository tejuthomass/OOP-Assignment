package assignment_3;

import java.util.Random;

public class Level_2 extends Thread {
	private int num;
	
	Level_2 (int num)
	{
		this.num = num;		
	}
	
	@Override
	public void run()
	{
		if (num < 0)
		{
			System.out.println(num + " is negative.");
		}
		else if((num >= 0) && (num % 2 == 0))
		{
			System.out.println(num + " is positive even.");
		}
		else
		{
			System.out.println(num + " is positive odd.");			
		}		
	}

	public static void main(String[] args) {
		Random r = new Random();
		
		int[] arr = new int[10];
		
		System.out.println("Generated random numbers: ");
		for (int i = 0; i < arr.length; i++)
		{
			arr[i] = r.nextInt(100);	
			System.out.print(arr[i] + " ");
		}
		
		System.out.println("\n\nResult:");
		for (int i = 0; i < arr.length; i++)
		{
			Level_2 ob = new Level_2(arr[i]);
			ob.start();
		}
	}
}
