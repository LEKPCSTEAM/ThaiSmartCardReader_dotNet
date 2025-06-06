﻿using System.Linq;

namespace ThaiNationalIDCard
{
    public abstract class APDU_THAILAND_IDCARD: IAPDU_THAILAND_IDCARD
    {
        // MOI AID
        public byte[] AID_MOI {
            get {
                return new byte[] { 0xA0, 0X00, 0x00, 0x00, 0x54, 0x48, 0x00, 0x01 };
            }
            set { }
        }

        // Select/Reset
        public byte[] APDU_SELECT(byte[] AID)
        {
            byte[] _select = new byte[] { 0x00, 0xA4, 0x04, 0x00, (byte)AID.Length };
            byte[] _tmp = new byte[_select.Length + AID.Length];
            _tmp = _select.Concat(AID).ToArray();
            return _tmp;
        }

        public abstract byte[] APDU_GET_RESPONSE();

        // Citizen ID
        public byte[] EF_CID
        {
            get
            {
                return new byte[] { 0x80, 0xb0, 0x00, 0x04, 0x02, 0x00, 0x0d };
            }
            set { }
        }

        // Fullname Thai + Eng + BirthDate + Sex
        public byte[] EF_PERSON_INFO
        {
            get
            {
                return new byte[] { 0x80, 0xb0, 0x00, 0x11, 0x02, 0x00, 0xd1 };
            }
            set { }
        } 

        // Address
        public byte[] EF_ADDRESS
        {
            get
            {
                return new byte[] { 0x80, 0xb0, 0x15, 0x79, 0x02, 0x00, 0x64 };
            }
            set { }
        } 

        // issue/expire
        public byte[] EF_CARD_ISSUE_EXPIRE
        {
            get
            {
                return new byte[] { 0x80, 0xb0, 0x01, 0x67, 0x02, 0x00, 0x12 };
            }
            set { }
        }

        // issuer
        public byte[] EF_CARD_ISSUER
        {
            get
            {
                return new byte[] { 0x80, 0xb0, 0x00, 0xf6, 0x02, 0x00, 0x64 };
            }
            set { }
        }

        // photo
        public byte[][] EF_CARD_PHOTO
        {
            get
            {
                return new byte[][]
                {
                    new byte[]{ 0x80, 0xB0, 0x01, 0x7B, 0x02, 0x00, 0xFF },
                    new byte[]{ 0x80, 0xB0, 0x02, 0x7A, 0x02, 0x00, 0xFF },
                    new byte[]{ 0x80, 0xB0, 0x03, 0x79, 0x02, 0x00, 0xFF },
                    new byte[]{ 0x80, 0xB0, 0x04, 0x78, 0x02, 0x00, 0xFF },
                    new byte[]{ 0x80, 0xB0, 0x05, 0x77, 0x02, 0x00, 0xFF },
                    new byte[]{ 0x80, 0xB0, 0x06, 0x76, 0x02, 0x00, 0xFF },
                    new byte[]{ 0x80, 0xB0, 0x07, 0x75, 0x02, 0x00, 0xFF },
                    new byte[]{ 0x80, 0xB0, 0x08, 0x74, 0x02, 0x00, 0xFF },
                    new byte[]{ 0x80, 0xB0, 0x09, 0x73, 0x02, 0x00, 0xFF },
                    new byte[]{ 0x80, 0xB0, 0x0A, 0x72, 0x02, 0x00, 0xFF },
                    new byte[]{ 0x80, 0xB0, 0x0B, 0x71, 0x02, 0x00, 0xFF },
                    new byte[]{ 0x80, 0xB0, 0x0C, 0x70, 0x02, 0x00, 0xFF },
                    new byte[]{ 0x80, 0xB0, 0x0D, 0x6F, 0x02, 0x00, 0xFF },
                    new byte[]{ 0x80, 0xB0, 0x0E, 0x6E, 0x02, 0x00, 0xFF },
                    new byte[]{ 0x80, 0xB0, 0x0F, 0x6D, 0x02, 0x00, 0xFF },
                    new byte[]{ 0x80, 0xB0, 0x10, 0x6C, 0x02, 0x00, 0xFF },
                    new byte[]{ 0x80, 0xB0, 0x11, 0x6B, 0x02, 0x00, 0xFF },
                    new byte[]{ 0x80, 0xB0, 0x12, 0x6A, 0x02, 0x00, 0xFF },
                    new byte[]{ 0x80, 0xB0, 0x13, 0x69, 0x02, 0x00, 0xFF },
                    new byte[]{ 0x80, 0xB0, 0x14, 0x68, 0x02, 0x00, 0xFF },
                };
            }
            set { }
        }

        // ศาสนา
        public byte[] EF_RELIGION
        {
            get
            {
                return new byte[] { 0x80, 0xB0, 0x01, 0x77, 0x02, 0x00, 0x02 };
            }
            set { }
        }

        // เลขใต้บัตร
        public byte[] EF_UNDER_CARD_NUMBER
        {
            get
            {
                return new byte[] { 0x80, 0xB0, 0x16, 0x19, 0x02, 0x00, 0x0E };
            }
            set { }
        }
    }
}
