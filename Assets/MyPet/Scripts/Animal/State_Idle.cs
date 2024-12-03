using UnityEngine;
using UnityEngine.AI;
using WOAT;

namespace MyPet.AI
{
    [System.Serializable]
    public class State_Idle : State<AnimalController>
    {
        // �ʵ�
        #region Variables
        private Animator animator;
        /*private CharacterController characterController;
        private NavMeshAgent navMeshAgent;*/
        #endregion

        // �������̵�
        #region Override
        // �ʱ�ȭ �޼��� - ���� �� 1ȸ ����
        public override void OnInitialized()
        {
            // ����
            animator = context.GetComponent<Animator>();
            /*characterController = context.GetComponent<CharacterController>();
            navMeshAgent = context.GetComponent<NavMeshAgent>();*/
        }

        // ���� ��ȯ �� State Enter�� 1ȸ ����
        public override void OnEnter() { }

        // ���� ��ȯ �� State Exit�� 1ȸ ����
        public override void OnExit() { }

        public override void Update(float deltaTime)
        {
            
        }
        #endregion
    }
}