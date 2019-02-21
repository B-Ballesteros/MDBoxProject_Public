using System;
using System.Collections.Generic;
using System.Text;

namespace MDBoxProject
{
    public class AxisData
    {
        #region Properties
        #region Fields
        private int xValue;
        private int yValue;
        private int zValue;
        private int uValue;
        private int vValue;
        private int wValue;
        private const int DEFAULT_MULTIPLIER = 1000;
        private const int EMPIRIC_MULTIPLIER = 2000;
        private int selectedMultiplier;
        #endregion Fields
        /// <summary>
        /// X Axis (first 4 bytes)
        /// </summary>
        public int X
        {
            get { return xValue * selectedMultiplier; }
            private set { xValue = value; }
        }

        /// <summary>
        /// Y Axis (4 bytes after X)
        /// </summary>
        public int Y
        {
            get { return yValue * selectedMultiplier; }
            private set { yValue = value; }
        }

        /// <summary>
        /// Z Axis (4 bytes afer Y)
        /// </summary>
        public int Z
        {
            get { return zValue * selectedMultiplier; }
            private set { zValue = value; }
        }

        /// <summary>
        /// U Axis (4 bytes after Z)
        /// </summary>
        public int U
        {
            get { return uValue * selectedMultiplier; }
            private set { uValue = value; }
        }

        /// <summary>
        /// V Axis (4 bytes after U)
        /// </summary>
        public int V
        {
            get { return vValue * selectedMultiplier; }
            private set { vValue = value; }
        }

        /// <summary>
        /// W Axis (last 4 bytes of axis data)
        /// </summary>
        public int W
        {
            get { return wValue * selectedMultiplier; }
            private set { wValue = value; }
        }
        #endregion Properties

        #region Constructors

        /// <summary>
        /// Default Constructor for Axis Data object, it uses the multiplier used by the manufacturer.
        /// </summary>
        /// <param name="x">Value of the X axis *from 0 to 100)</param>
        /// <param name="y">Value of the Y axis *from 0 to 100)</param>
        /// <param name="z">Value of the Z axis *from 0 to 100)</param>
        /// <param name="u">Value of the U axis *from 0 to 100)</param>
        /// <param name="v">Value of the V axis *from 0 to 100)</param>
        /// <param name="w">Value of the W axis *from 0 to 100)</param>
        public AxisData(int x, int y, int z, int u, int v, int w) : this(x, y, z, u, v, w, true)
        { }

        /// <summary>
        /// Specialized constructor made due user findings regardless the multiplier used to transform axis data to the UDP packet.
        /// </summary>
        /// <param name="x">Value of the X axis *from 0 to 100)</param>
        /// <param name="y">Value of the Y axis *from 0 to 100)</param>
        /// <param name="z">Value of the Z axis *from 0 to 100)</param>
        /// <param name="u">Value of the U axis *from 0 to 100)</param>
        /// <param name="v">Value of the V axis *from 0 to 100)</param>
        /// <param name="w">Value of the W axis *from 0 to 100)</param>
        /// <param name="useDefaultMultiplier">Allows the user to select between the multiplier used by the manufacturer or the oe discovered by the user.</param>
        public AxisData(int x, int y, int z, int u, int v, int w, bool useDefaultMultiplier)
        {
            xValue = x;
            yValue = y;
            zValue = z;
            uValue = u;
            vValue = v;
            wValue = w;
            selectedMultiplier = useDefaultMultiplier ? DEFAULT_MULTIPLIER : EMPIRIC_MULTIPLIER;
        }

        #endregion Constructors
    }
}
