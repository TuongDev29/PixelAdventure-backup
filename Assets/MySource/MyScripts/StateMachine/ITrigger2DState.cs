using UnityEngine;

public interface ITrigger2DState
{
    public void OnTriggerEnter2D(Collider2D other);
    public void OnTriggerExit2D(Collider2D other);

}
