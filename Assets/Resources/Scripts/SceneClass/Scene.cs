using UnityEngine;
using System.Collections;

public class Scene : MonoBehaviour {
    public bool b_Running = false;
    public virtual void Initialize()    { }
    public virtual void Updated()       { }
    public virtual void Exit()          { }
}
