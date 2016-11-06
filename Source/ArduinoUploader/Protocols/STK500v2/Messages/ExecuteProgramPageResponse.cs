﻿namespace ArduinoUploader.Protocols.STK500v2.Messages
{
    internal class ExecuteProgramPageResponse : Response
    {
        public byte AnswerID { get { return Bytes[0]; } }
        public byte Status { get { return Bytes[1]; } }
    }
}