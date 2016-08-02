package md545b60305c9045b747f7db0d546a864c7;


public class HotDogDetailActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("NorbisHotDog.Droid.Activities.HotDogDetailActivity, NorbisHotDog.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", HotDogDetailActivity.class, __md_methods);
	}


	public HotDogDetailActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == HotDogDetailActivity.class)
			mono.android.TypeManager.Activate ("NorbisHotDog.Droid.Activities.HotDogDetailActivity, NorbisHotDog.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
