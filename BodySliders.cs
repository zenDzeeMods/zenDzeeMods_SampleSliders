using TaleWorlds.Core;

namespace zenDzeeMods
{
    class BodySliders
    {
        private ulong KeyPart6;
        private ulong KeyPart5;
        private ulong KeyPart4;
        private ulong KeyPart3;
        private ulong KeyPart2;
        private ulong KeyPart1;
        private ulong KeyPart8;
        private ulong KeyPart7;

        public BodySliders(StaticBodyProperties properties)
        {
            KeyPart1 = properties.KeyPart1;
            KeyPart2 = properties.KeyPart2;
            KeyPart3 = properties.KeyPart3;
            KeyPart4 = properties.KeyPart4;
            KeyPart5 = properties.KeyPart5;
            KeyPart6 = properties.KeyPart6;
            KeyPart7 = properties.KeyPart7;
            KeyPart8 = properties.KeyPart8;
        }

        public StaticBodyProperties GetStaticBodyProperties()
        {
            return new StaticBodyProperties(KeyPart1, KeyPart2, KeyPart3, KeyPart4, KeyPart5, KeyPart6, KeyPart7, KeyPart8);
        }

        private void SetHalfByte(ref ulong key, int position, byte value)
        {
            position *= 4;
            ulong s = value;
            ulong n = s << position;
            s = 0x0Ful << position;
            key = (key & ~s) | n;
        }
        private byte GetHalfByte(ulong key, int position)
        {
            position *= 4;
            return (byte)((key >> position) & 0x0Ful);
        }

        public byte FaceWidth
        {
            get { return GetHalfByte(KeyPart2, 0); }
            set { SetHalfByte(ref KeyPart2, 0, value); }
        }
        public byte FaceDepth
        {
            get { return GetHalfByte(KeyPart2, 1); }
            set { SetHalfByte(ref KeyPart2, 1, value); }
        }
        public byte FaceCenterHeight
        {
            get { return GetHalfByte(KeyPart2, 2); }
            set { SetHalfByte(ref KeyPart2, 2, value); }
        }
        public byte FaceRatio
        {
            get { return GetHalfByte(KeyPart2, 3); }
            set { SetHalfByte(ref KeyPart2, 3, value); }
        }
        public byte FaceWeight
        {
            get { return GetHalfByte(KeyPart2, 4); }
            set { SetHalfByte(ref KeyPart2, 4, value); }
        }
        public byte FaceCheekboneHeight
        {
            get { return GetHalfByte(KeyPart2, 5); }
            set { SetHalfByte(ref KeyPart2, 5, value); }
        }
        public byte FaceCheekboneWidth
        {
            get { return GetHalfByte(KeyPart2, 6); }
            set { SetHalfByte(ref KeyPart2, 6, value); }
        }
        public byte FaceCheekboneDepth
        {
            get { return GetHalfByte(KeyPart2, 7); }
            set { SetHalfByte(ref KeyPart2, 7, value); }
        }
        public byte FaceSharpness
        {
            get { return GetHalfByte(KeyPart2, 8); }
            set { SetHalfByte(ref KeyPart2, 8, value); }
        }
        public byte FaceTempleWidth
        {
            get { return GetHalfByte(KeyPart2, 9); }
            set { SetHalfByte(ref KeyPart2, 9, value); }
        }
        public byte FaceEyeSocketSize
        {
            get { return GetHalfByte(KeyPart2, 10); }
            set { SetHalfByte(ref KeyPart2, 10, value); }
        }
        public byte FaceEarShape
        {
            get { return GetHalfByte(KeyPart2, 11); }
            set { SetHalfByte(ref KeyPart2, 11, value); }
        }
        public byte FaceEarSize
        {
            get { return GetHalfByte(KeyPart2, 12); }
            set { SetHalfByte(ref KeyPart2, 12, value); }
        }
        public byte FaceAsymmetry
        {
            get { return GetHalfByte(KeyPart2, 13); }
            set { SetHalfByte(ref KeyPart2, 13, value); }
        }

        public byte EyeEyebrowType
        {
            get { return GetHalfByte(KeyPart8, 3); }
            set { SetHalfByte(ref KeyPart8, 3, value); }
        }
        public byte EyeEyebrowDepth
        {
            get { return GetHalfByte(KeyPart2, 14); }
            set { SetHalfByte(ref KeyPart2, 14, value); }
        }
        public byte EyeBrowOuterHeight
        {
            get { return GetHalfByte(KeyPart2, 15); }
            set { SetHalfByte(ref KeyPart2, 15, value); }
        }
        public byte EyeBrowMiddleHeight
        {
            get { return GetHalfByte(KeyPart3, 0); }
            set { SetHalfByte(ref KeyPart3, 0, value); }
        }
        public byte EyeBrowInnerHeight
        {
            get { return GetHalfByte(KeyPart3, 1); }
            set { SetHalfByte(ref KeyPart3, 1, value); }
        }
        public byte EyePosition
        {
            get { return GetHalfByte(KeyPart3, 2); }
            set { SetHalfByte(ref KeyPart3, 2, value); }
        }
        public byte EyeSize
        {
            get { return GetHalfByte(KeyPart3, 3); }
            set { SetHalfByte(ref KeyPart3, 3, value); }
        }
        public byte EyeMonolidEyes
        {
            get { return GetHalfByte(KeyPart3, 4); }
            set { SetHalfByte(ref KeyPart3, 4, value); }
        }
        public byte EyeEyelidHeight
        {
            get { return GetHalfByte(KeyPart3, 5); }
            set { SetHalfByte(ref KeyPart3, 5, value); }
        }
        public byte EyeDepth
        {
            get { return GetHalfByte(KeyPart3, 6); }
            set { SetHalfByte(ref KeyPart3, 6, value); }
        }
        public byte EyeShape
        {
            get { return GetHalfByte(KeyPart3, 7); }
            set { SetHalfByte(ref KeyPart3, 7, value); }
        }
        public byte EyeOuterHeight
        {
            get { return GetHalfByte(KeyPart3, 8); }
            set { SetHalfByte(ref KeyPart3, 8, value); }
        }
        public byte EyeInnerHeight
        {
            get { return GetHalfByte(KeyPart3, 9); }
            set { SetHalfByte(ref KeyPart3, 9, value); }
        }
        public byte EyeToEyeDistance
        {
            get { return GetHalfByte(KeyPart3, 10); }
            set { SetHalfByte(ref KeyPart3, 10, value); }
        }
        public byte EyeAsymmetry
        {
            get { return GetHalfByte(KeyPart3, 11); }
            set { SetHalfByte(ref KeyPart3, 11, value); }
        }
        public byte EyeColor
        {
            get { return GetHalfByte(KeyPart1, 11); }
            set { SetHalfByte(ref KeyPart1, 11, value); }
        }

        public byte NoseAngle
        {
            get { return GetHalfByte(KeyPart3, 12); }
            set { SetHalfByte(ref KeyPart3, 12, value); }
        }
        public byte NoseLength
        {
            get { return GetHalfByte(KeyPart3, 13); }
            set { SetHalfByte(ref KeyPart3, 13, value); }
        }
        public byte NoseBridge
        {
            get { return GetHalfByte(KeyPart3, 14); }
            set { SetHalfByte(ref KeyPart3, 14, value); }
        }
        public byte NoseTipHeight
        {
            get { return GetHalfByte(KeyPart3, 15); }
            set { SetHalfByte(ref KeyPart3, 15, value); }
        }
        public byte NoseSize
        {
            get { return GetHalfByte(KeyPart4, 0); }
            set { SetHalfByte(ref KeyPart4, 0, value); }
        }
        public byte NoseWidth
        {
            get { return GetHalfByte(KeyPart4, 1); }
            set { SetHalfByte(ref KeyPart4, 1, value); }
        }
        public byte NoseNostrilHeight
        {
            get { return GetHalfByte(KeyPart4, 2); }
            set { SetHalfByte(ref KeyPart4, 2, value); }
        }
        public byte NoseNostrilSize
        {
            get { return GetHalfByte(KeyPart4, 3); }
            set { SetHalfByte(ref KeyPart4, 3, value); }
        }
        public byte NoseBump
        {
            get { return GetHalfByte(KeyPart4, 4); }
            set { SetHalfByte(ref KeyPart4, 4, value); }
        }
        public byte NoseDefenition
        {
            get { return GetHalfByte(KeyPart4, 5); }
            set { SetHalfByte(ref KeyPart4, 5, value); }
        }
        public byte NoseShape
        {
            get { return GetHalfByte(KeyPart4, 6); }
            set { SetHalfByte(ref KeyPart4, 6, value); }
        }
        public byte NoseAsymmetry
        {
            get { return GetHalfByte(KeyPart4, 7); }
            set { SetHalfByte(ref KeyPart4, 7, value); }
        }

        public byte MouthTeethType
        {
            get { return GetHalfByte(KeyPart8, 1); }
            set { SetHalfByte(ref KeyPart8, 1, value); }
        }
        public byte MouthWidth
        {
            get { return GetHalfByte(KeyPart4, 8); }
            set { SetHalfByte(ref KeyPart4, 8, value); }
        }
        public byte MouthPosition
        {
            get { return GetHalfByte(KeyPart4, 9); }
            set { SetHalfByte(ref KeyPart4, 9, value); }
        }
        public byte MouthFrowSmile
        {
            get { return GetHalfByte(KeyPart4, 10); }
            set { SetHalfByte(ref KeyPart4, 10, value); }
        }
        public byte MouthLipThickness
        {
            get { return GetHalfByte(KeyPart4, 11); }
            set { SetHalfByte(ref KeyPart4, 11, value); }
        }
        public byte MouthForward
        {
            get { return GetHalfByte(KeyPart4, 12); }
            set { SetHalfByte(ref KeyPart4, 12, value); }
        }
        public byte MouthBottomLipShape
        {
            get { return GetHalfByte(KeyPart4, 13); }
            set { SetHalfByte(ref KeyPart4, 13, value); }
        }
        public byte MouthTopLipShape
        {
            get { return GetHalfByte(KeyPart4, 14); }
            set { SetHalfByte(ref KeyPart4, 14, value); }
        }
        public byte MouthLipsConcaveConvex
        {
            get { return GetHalfByte(KeyPart4, 15); }
            set { SetHalfByte(ref KeyPart4, 15, value); }
        }
        public byte MouthJawLine
        {
            get { return GetHalfByte(KeyPart5, 0); }
            set { SetHalfByte(ref KeyPart5, 0, value); }
        }
        public byte MouthJawShape
        {
            get { return GetHalfByte(KeyPart5, 1); }
            set { SetHalfByte(ref KeyPart5, 1, value); }
        }
        public byte MouthJawHeight
        {
            get { return GetHalfByte(KeyPart5, 2); }
            set { SetHalfByte(ref KeyPart5, 2, value); }
        }
        public byte MouthChinForward
        {
            get { return GetHalfByte(KeyPart5, 3); }
            set { SetHalfByte(ref KeyPart5, 3, value); }
        }
        public byte MouthChinShape
        {
            get { return GetHalfByte(KeyPart5, 4); }
            set { SetHalfByte(ref KeyPart5, 4, value); }
        }
        public byte MouthChinLength
        {
            get { return GetHalfByte(KeyPart5, 5); }
            set { SetHalfByte(ref KeyPart5, 5, value); }
        }
    }
}
