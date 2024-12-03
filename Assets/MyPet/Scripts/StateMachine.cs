using System.Collections.Generic;
using UnityEngine;

namespace WOAT
{
    /// <summary>
    /// <T> 상태 정의
    /// </summary>
    [System.Serializable]
    public abstract class State<T>
    {
        // 필드
        #region
        protected StateMachine<T> stateMachine; // 현재 State가 등록 되어있는 Machine
        protected T context;                    // stateMachine을 가지고 있는 주체
        #endregion

        // 생성자
        #region Constructor
        public State() { }
        #endregion

        // 메서드
        #region Methods
        public void SetMachineAndContext(StateMachine<T> stateMachine, T context)
        {
            this.stateMachine = stateMachine;
            this.context = context;

            OnInitialized();
        }

        // 초기화 메서드 - 생성 후 1회 실행
        public virtual void OnInitialized() { }

        // 상태 전환 시 State Enter에 1회 실행
        public virtual void OnEnter() { }

        // 상태 전환 시 State Exit에 1회 실행
        public virtual void OnExit() { }

        // 상태 실행 중
        public abstract void Update(float deltaTime);
        #endregion
    }

    /// <summary>
    /// State를 관리하는 클래스
    /// </summary>
    public class StateMachine<T>
    {
        // 필드
        #region Variables
        private float elapsedTimeInState = 0.0f;// 현재 상태 지속 시간
        private T context;                      // StateMachine을 가지고 있는 주체

        // 등록된 상태와 상태의 타입을 저장
        private Dictionary<System.Type, State<T>> states = new();
        #endregion

        // 속성
        #region Properties
        public float ElapsedTimeInState => elapsedTimeInState;
        public State<T> CurrentState { get; private set; }
        public State<T> PreviousState { get; private set; }
        #endregion

        // 생성자
        #region Constructor
        public StateMachine(T context, State<T> initialState)
        {
            this.context = context;
            AddState(initialState);
            CurrentState = initialState;
            CurrentState.OnEnter();
        }
        #endregion

        // 메서드
        #region Methods
        // State 등록
        public void AddState(State<T> state)
        {
            state.SetMachineAndContext(this, context);
            states[state.GetType()] = state;
        }

        // StateMachine에서 State의 업데이트 실행
        public void Update(float deltaTime)
        {
            elapsedTimeInState += deltaTime;
            CurrentState.Update(deltaTime);
        }

        // CurrentState 체인지
        public R ChangeState<R>() where R : State<T>
        {
            // 현 상태와 새로운 상태 비교
            var newType = typeof(R);
            if (CurrentState.GetType() == newType)
            {
                return CurrentState as R;
            }

            // 상태 변경 이전
            CurrentState?.OnExit();
            PreviousState = CurrentState;

            // 상태 변경
            CurrentState = states[newType];
            CurrentState.OnEnter();
            elapsedTimeInState = 0.0f;
            return CurrentState as R;
        }
        #endregion
    }
}