using UnityEngine;
using WOAT;

namespace MyPet.AI
{
    public class State_Drink : State<AnimalController>
    {
        // 필드
        #region Variables
        private Animator animator;

        // animator parameter
        protected int isDrinkHash = Animator.StringToHash("IsDrink");
        #endregion

        // 오버라이드
        #region Override
        // 초기화 메서드 - 생성 후 1회 실행
        public override void OnInitialized()
        {
            // 참조
            animator = context.GetComponent<Animator>();
        }

        // 상태 전환 시 State Enter에 1회 실행
        public override void OnEnter()
        {
            animator.SetBool(isDrinkHash, true);
        }

        // 상태 전환 시 State Exit에 1회 실행
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