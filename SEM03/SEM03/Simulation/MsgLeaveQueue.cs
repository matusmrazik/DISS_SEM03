using OSPABA;

namespace SEM03.Simulation
{
    public class MsgLeaveQueue : MessageForm
    {
        public MsgCarService Message { get; set; }

        public MsgLeaveQueue(OSPABA.Simulation mySim)
            : base(mySim)
        {
            Message = null;
        }

        public MsgLeaveQueue(MessageForm original)
            : base(original)
        {
            // copy() is called in superclass
        }

        public override MessageForm CreateCopy()
        {
            return new MsgLeaveQueue(this);
        }

        protected override void Copy(MessageForm message)
        {
            base.Copy(message);
            var original = (MsgLeaveQueue)message;

            Message = original.Message;
        }
    }
}
