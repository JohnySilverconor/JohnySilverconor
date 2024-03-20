using System;
using System.Windows.Forms;

namespace CounterApp
{
    public class Counter : Form
    {
        private double currentValue;

        public Counter()
        {
            Reset();
        }

        public void AddToValue(double amountToAdd)
        {
            currentValue += amountToAdd;
            UpdateDisplay();
        }

        public void SetValue(double amount)
        {
            currentValue = amount;
            UpdateDisplay();
        }

        public void Reset()
        {
            currentValue = 0;
            UpdateDisplay();
        }

        public virtual void UpdateDisplay()
        {
            // Implement display logic here
        }

        public virtual void UpdateError(string errorText)
        {
            // Implement error handling logic here
        }
    }

    public class LoadingProgress : Counter
    {
        public LoadingProgress()
        {
        }

        public override void UpdateDisplay()
        {
            base.UpdateDisplay();
            // Assuming percentDisplay is a UI control (e.g., TextBox)
            percentDisplay.Text = currentValue.ToString();
        }

        public override void UpdateError(string errorText)
        {
            base.UpdateError(errorText);
            // Assuming errorDisplay is a UI control (e.g., TextBox)
            errorDisplay.Text = errorText;
        }
    }
}



package
{
	import flash.text.TextField;
public class Counter extends MovieClip
	{
		public var currentValue:Number;
		public function Counter()
		{
			reset();
		}
		public function addToValue( amountToAdd:Number ):void
		{
			currentValue = currentValue + amountToAdd;
			updateDisplay();
		}
		public function setValue( amount:Number ):void
		{
			currentValue = amount;
			updateDisplay();
		}
		public function reset():void
		{
			currentValue = 0;
			updateDisplay();
		}
		
		public function updateDisplay():void
		{	
		}
		public function updateError(errorText:String):void
		{	
		}
	}

	public class LoadingProgress extends Counter
	{
		public function LoadingProgress()
		{
			super();
		}
		override public function updateDisplay():void
		{
			super.updateDisplay();
			percentDisplay.text = currentValue.toString();
		}
		override public function updateError(errorText:String):void
		{
			super.updateError(errorText);
			errorDisplay.text = errorText;
		}
	}
}