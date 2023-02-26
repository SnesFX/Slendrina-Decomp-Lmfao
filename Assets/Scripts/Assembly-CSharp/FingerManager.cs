using System;
using System.Collections;
using UnityEngine;

public class FingerManager : MonoBehaviour
{
	public ArrayList elements = new ArrayList();

	public ArrayList fingers = new ArrayList();

	public void AddFingerListener(GUIElement element)
	{
		elements.Add(element);
	}

	public void RemoveFingerListener(GUIElement element)
	{
		elements.Remove(element);
	}

	private void Update()
	{
		Touch[] touches = Input.touches;
		for (int i = 0; i < touches.Length; i++)
		{
			Touch touch = touches[i];
			if (touch.phase == TouchPhase.Began)
			{
				Finger finger = new Finger();
				finger.touch = touch;
				Ray ray = Camera.main.ScreenPointToRay(touch.position);
				RaycastHit[] array = Physics.RaycastAll(ray);
				RaycastHit[] array2 = array;
				for (int j = 0; j < array2.Length; j++)
				{
					RaycastHit raycastHit = array2[j];
					finger.colliders.Add(raycastHit.collider);
					GameObject gameObject = raycastHit.collider.gameObject;
					gameObject.SendMessage("FingerBegin", touch, SendMessageOptions.DontRequireReceiver);
				}
				IEnumerator enumerator = elements.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						GUITexture gUITexture = (GUITexture)enumerator.Current;
						if (gUITexture.HitTest(touch.position))
						{
							finger.elements.Add(gUITexture);
							GameObject gameObject2 = gUITexture.gameObject;
							gameObject2.SendMessage("FingerBegin", touch, SendMessageOptions.DontRequireReceiver);
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = enumerator as IDisposable) != null)
					{
						disposable.Dispose();
					}
				}
				fingers.Add(finger);
			}
			else if (touch.phase == TouchPhase.Moved)
			{
				for (int k = 0; k < fingers.Count; k++)
				{
					Finger finger2 = (Finger)fingers[k];
					if (finger2.touch.fingerId != touch.fingerId)
					{
						continue;
					}
					finger2.moved = true;
					IEnumerator enumerator2 = finger2.colliders.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							Collider collider = (Collider)enumerator2.Current;
							if (!(collider == null))
							{
								GameObject gameObject3 = collider.gameObject;
								gameObject3.SendMessage("FingerMove", touch, SendMessageOptions.DontRequireReceiver);
							}
						}
					}
					finally
					{
						IDisposable disposable2;
						if ((disposable2 = enumerator2 as IDisposable) != null)
						{
							disposable2.Dispose();
						}
					}
					IEnumerator enumerator3 = finger2.elements.GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							GUITexture gUITexture2 = (GUITexture)enumerator3.Current;
							if (!(gUITexture2 == null))
							{
								GameObject gameObject4 = gUITexture2.gameObject;
								gameObject4.SendMessage("FingerMove", touch, SendMessageOptions.DontRequireReceiver);
							}
						}
					}
					finally
					{
						IDisposable disposable3;
						if ((disposable3 = enumerator3 as IDisposable) != null)
						{
							disposable3.Dispose();
						}
					}
				}
			}
			else
			{
				if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
				{
					continue;
				}
				Ray ray2 = Camera.main.ScreenPointToRay(touch.position);
				RaycastHit[] array = Physics.RaycastAll(ray2);
				int num = 0;
				while (num < fingers.Count)
				{
					Finger finger3 = (Finger)fingers[num];
					if (finger3.touch.fingerId == touch.fingerId)
					{
						IEnumerator enumerator4 = finger3.colliders.GetEnumerator();
						try
						{
							while (enumerator4.MoveNext())
							{
								Collider collider2 = (Collider)enumerator4.Current;
								if (collider2 == null)
								{
									continue;
								}
								bool flag = true;
								RaycastHit[] array3 = array;
								foreach (RaycastHit raycastHit2 in array3)
								{
									if (raycastHit2.collider == collider2)
									{
										flag = false;
										GameObject gameObject5 = collider2.gameObject;
										gameObject5.SendMessage("FingerEnd", touch, SendMessageOptions.DontRequireReceiver);
									}
								}
								if (flag)
								{
									GameObject gameObject6 = collider2.gameObject;
									gameObject6.SendMessage("FingerCancel", touch, SendMessageOptions.DontRequireReceiver);
								}
							}
						}
						finally
						{
							IDisposable disposable4;
							if ((disposable4 = enumerator4 as IDisposable) != null)
							{
								disposable4.Dispose();
							}
						}
						IEnumerator enumerator5 = finger3.elements.GetEnumerator();
						try
						{
							while (enumerator5.MoveNext())
							{
								GUITexture gUITexture3 = (GUITexture)enumerator5.Current;
								if (!(gUITexture3 == null))
								{
									bool flag2 = true;
									if (gUITexture3.HitTest(touch.position))
									{
										flag2 = false;
										GameObject gameObject7 = gUITexture3.gameObject;
										gameObject7.SendMessage("FingerEnd", touch, SendMessageOptions.DontRequireReceiver);
									}
									if (flag2)
									{
										GameObject gameObject8 = gUITexture3.gameObject;
										gameObject8.SendMessage("FingerCancel", touch, SendMessageOptions.DontRequireReceiver);
									}
								}
							}
						}
						finally
						{
							IDisposable disposable5;
							if ((disposable5 = enumerator5 as IDisposable) != null)
							{
								disposable5.Dispose();
							}
						}
						fingers[num] = fingers[fingers.Count - 1];
						fingers.RemoveAt(fingers.Count - 1);
					}
					else
					{
						num++;
					}
				}
			}
		}
	}
}
