namespace DieRoller
{
    /// <summary>
    /// Represents a single six sided die (1 - 6)
    /// </summary>
    public class SingleDie
    {
        /// <summary>
        /// Current face up value of the die
        /// </summary>
        public byte FaceValue { get; set; }

        /// <summary>
        /// True if the die is currently held
        /// </summary>
        public bool IsHeld { get; set; }  

        /// <summary>
        /// Rolls the die and sets the <see cref="FaceValue"/> to the new number.
        /// Returns the new number.
        /// </summary>
        /// <returns> 
        /// Returns the new random number 
        /// </returns>
        public byte Roll()
        {
            // Generate random number
            // set to face value
            // return new number
            throw new NotImplementedException(); // place holder stub
        }
       

        // Roll (set a new random face up value)


    }
}
