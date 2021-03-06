namespace Asterisk.NET.Manager.Event
{
	/// <summary>
	/// An AgentCallbackLoginEvent is triggered when an agent is successfully logged in using AgentCallbackLogin.<br/>
	/// It is implemented in <code>channels/chan_agent.c</code>
	/// </summary>
	/// <seealso cref="Manager.event.AgentCallbackLogoffEvent" />
	public class AgentCallbackLoginEvent : ManagerEvent
	{
		private string agent;
		private string loginChan;

		/// <summary>
		/// Get/Set the name of the agent that logged in.
		/// </summary>
		public string Agent
		{
			get { return agent; }
			set { this.agent = value; }
		}
		public string LoginChan
		{
			get { return loginChan; }
			set { this.loginChan = value; }
		}

		public AgentCallbackLoginEvent(ManagerConnection source)
			: base(source)
		{ }
	}
}