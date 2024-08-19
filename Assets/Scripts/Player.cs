using System;
using Elympics;
using UnityEngine;

public class Player : ElympicsMonoBehaviour, IInitializable, IUpdatable, IInputHandler
{
    [SerializeField] private PlayerUI ui;

    private bool _a;
    private bool _d;
    
    public void Initialize()
    {
        ui.SetNickname($"Player {(int)PredictableFor}");    
    }

    private void Update()
    {
        _a = Input.GetKey(KeyCode.A);
        _d = Input.GetKey(KeyCode.D);
    }

    public void ElympicsUpdate()
    {
        if (ElympicsBehaviour.TryGetInput(PredictableFor, out var reader))
        {
            reader.Read(out bool a);
            reader.Read(out bool d);
            
            if (a)
            {
                transform.position += Vector3.left * Time.deltaTime * 10f;
            }
            else if (d)
            {
                transform.position += Vector3.right * Time.deltaTime * 10f;
            }
        }
    }

    public void OnInputForClient(IInputWriter inputSerializer)
    {
        inputSerializer.Write(_a);
        inputSerializer.Write(_d);
    }

    public void OnInputForBot(IInputWriter inputSerializer)
    {
        
    }
}