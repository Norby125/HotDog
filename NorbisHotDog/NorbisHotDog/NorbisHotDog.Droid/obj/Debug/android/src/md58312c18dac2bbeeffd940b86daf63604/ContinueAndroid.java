package md58312c18dac2bbeeffd940b86daf63604;


public class ContinueAndroid
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("NorbisHotDog.Droid.ContinueAndroid, NorbisHotDog.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ContinueAndroid.class, __md_methods);
	}


	public ContinueAndroid () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ContinueAndroid.class)
			mono.android.TypeManager.Activate ("NorbisHotDog.Droid.ContinueAndroid, NorbisHotDog.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
