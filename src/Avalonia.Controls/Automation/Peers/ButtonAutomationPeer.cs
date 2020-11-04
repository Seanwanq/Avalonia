#nullable enable

namespace Avalonia.Controls.Automation.Peers
{
    public class ButtonAutomationPeer : ContentControlAutomationPeerBase,
        IInvocableAutomationPeer
    {
        public ButtonAutomationPeer(Control owner): base(owner) {}
        public void Invoke() => (Owner as Button)?.PerformClick();
    }
}

