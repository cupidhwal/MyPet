using UnityEngine;

namespace MyPet.AI
{
    public class DogController : AnimalController
    {
        protected override void Start()
        {
            base.Start();   // StateMachine ���� �� State_Idle ���

            // ������ ������ ���� �߰� ���
            stateMachine.AddState(new State_Sit());
            stateMachine.AddState(new State_Drink());
        }

        public void Button_Idle()
        {
            ChangeState<State_Idle>();
        }

        public void Button_Sit()
        {
            ChangeState<State_Sit>();
        }

        public void Button_Drink()
        {
            ChangeState<State_Drink>();
        }
    }
}