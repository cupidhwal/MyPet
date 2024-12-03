using UnityEngine;
using WOAT;

namespace MyPet.AI
{
    public class State_Drink : State<AnimalController>
    {
        // �ʵ�
        #region Variables
        private Animator animator;

        // animator parameter
        protected int isDrinkHash = Animator.StringToHash("IsDrink");
        #endregion

        // �������̵�
        #region Override
        // �ʱ�ȭ �޼��� - ���� �� 1ȸ ����
        public override void OnInitialized()
        {
            // ����
            animator = context.GetComponent<Animator>();
        }

        // ���� ��ȯ �� State Enter�� 1ȸ ����
        public override void OnEnter()
        {
            animator.SetBool(isDrinkHash, true);
        }

        // ���� ��ȯ �� State Exit�� 1ȸ ����
        public override void OnExit()
        {
            animator.SetBool(isDrinkHash, false);
        }

        public override void Update(float deltaTime)
        {
            
        }
        #endregion
    }
}