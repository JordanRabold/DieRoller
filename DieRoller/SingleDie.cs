namespace DieRoller
{
    /// <summary>
    /// Represents a single six sided die (1 - 6)
    /// </summary>
    public class Die
    {
        /// <summary>
        /// Constructor creates the die and rolls it to start with a random number
        /// </summary>
        public Die()
        {
            Roll();
        }
        /// <summary>
        /// Current face up value of the die
        /// </summary>
        public byte FaceValue { get; private set; }

        /// <summary>
        /// True if the die is currently held
        /// </summary>
        public bool IsHeld { get; set; }  

        /// <summary>
        /// Rolls the die and sets the <see cref="FaceValue"/> to the new number
        /// if the die is not currently held.
        /// Returns the new number.
        /// </summary>
        /// <returns> 
        /// Returns the new random number 
        /// </returns>
        public byte Roll()
        {
            if (!IsHeld)
            {
                // Generate random number
                Random random = new Random();
                byte newValue = (byte)random.Next(1, 7);

                // set to face value
                FaceValue = newValue;
            }
     
            // return new number
            return FaceValue;
        }
    }
}
