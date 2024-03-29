//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Collections.Generic;
using System.Text;
using RosMessageGeneration;

namespace RosMessageTypes.Logging
{
    public class Gazetracking : Message
    {
        public const string RosMessageName = "Logging/Gazetracking";

        public float left_position_x;
        public float left_position_y;
        public float left_position_z;
        public float left_rotation_x;
        public float left_rotation_y;
        public float left_rotation_z;
        public float left_rotation_w;
        public float right_position_x;
        public float right_position_y;
        public float right_position_z;
        public float right_rotation_x;
        public float right_rotation_y;
        public float right_rotation_z;
        public float right_rotation_w;
        public float fix_position_x;
        public float fix_position_y;
        public float fix_position_z;
        public float game_time;

        public Gazetracking()
        {
            this.left_position_x = 0.0f;
            this.left_position_y = 0.0f;
            this.left_position_z = 0.0f;
            this.left_rotation_x = 0.0f;
            this.left_rotation_y = 0.0f;
            this.left_rotation_z = 0.0f;
            this.left_rotation_w = 0.0f;
            this.right_position_x = 0.0f;
            this.right_position_y = 0.0f;
            this.right_position_z = 0.0f;
            this.right_rotation_x = 0.0f;
            this.right_rotation_y = 0.0f;
            this.right_rotation_z = 0.0f;
            this.right_rotation_w = 0.0f;
            this.fix_position_x = 0.0f;
            this.fix_position_y = 0.0f;
            this.fix_position_z = 0.0f;
            this.game_time = 0.0f;
        }

        public Gazetracking(float left_position_x, float left_position_y, float left_position_z, float left_rotation_x, float left_rotation_y, float left_rotation_z, float left_rotation_w, float right_position_x, float right_position_y, float right_position_z, float right_rotation_x, float right_rotation_y, float right_rotation_z, float right_rotation_w, float fix_position_x, float fix_position_y, float fix_position_z, float game_time)
        {
            this.left_position_x = left_position_x;
            this.left_position_y = left_position_y;
            this.left_position_z = left_position_z;
            this.left_rotation_x = left_rotation_x;
            this.left_rotation_y = left_rotation_y;
            this.left_rotation_z = left_rotation_z;
            this.left_rotation_w = left_rotation_w;
            this.right_position_x = right_position_x;
            this.right_position_y = right_position_y;
            this.right_position_z = right_position_z;
            this.right_rotation_x = right_rotation_x;
            this.right_rotation_y = right_rotation_y;
            this.right_rotation_z = right_rotation_z;
            this.right_rotation_w = right_rotation_w;
            this.fix_position_x = fix_position_x;
            this.fix_position_y = fix_position_y;
            this.fix_position_z = fix_position_z;
            this.game_time = game_time;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.Add(BitConverter.GetBytes(this.left_position_x));
            listOfSerializations.Add(BitConverter.GetBytes(this.left_position_y));
            listOfSerializations.Add(BitConverter.GetBytes(this.left_position_z));
            listOfSerializations.Add(BitConverter.GetBytes(this.left_rotation_x));
            listOfSerializations.Add(BitConverter.GetBytes(this.left_rotation_y));
            listOfSerializations.Add(BitConverter.GetBytes(this.left_rotation_z));
            listOfSerializations.Add(BitConverter.GetBytes(this.left_rotation_w));
            listOfSerializations.Add(BitConverter.GetBytes(this.right_position_x));
            listOfSerializations.Add(BitConverter.GetBytes(this.right_position_y));
            listOfSerializations.Add(BitConverter.GetBytes(this.right_position_z));
            listOfSerializations.Add(BitConverter.GetBytes(this.right_rotation_x));
            listOfSerializations.Add(BitConverter.GetBytes(this.right_rotation_y));
            listOfSerializations.Add(BitConverter.GetBytes(this.right_rotation_z));
            listOfSerializations.Add(BitConverter.GetBytes(this.right_rotation_w));
            listOfSerializations.Add(BitConverter.GetBytes(this.fix_position_x));
            listOfSerializations.Add(BitConverter.GetBytes(this.fix_position_y));
            listOfSerializations.Add(BitConverter.GetBytes(this.fix_position_z));
            listOfSerializations.Add(BitConverter.GetBytes(this.game_time));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            this.left_position_x = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.left_position_y = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.left_position_z = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.left_rotation_x = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.left_rotation_y = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.left_rotation_z = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.left_rotation_w = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.right_position_x = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.right_position_y = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.right_position_z = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.right_rotation_x = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.right_rotation_y = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.right_rotation_z = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.right_rotation_w = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.fix_position_x = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.fix_position_y = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.fix_position_z = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.game_time = BitConverter.ToSingle(data, offset);
            offset += 4;

            return offset;
        }

    }
}
