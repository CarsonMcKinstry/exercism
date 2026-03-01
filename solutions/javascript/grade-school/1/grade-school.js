//
// This is only a SKELETON file for the 'Grade School' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class GradeSchool {
    constructor() {
        this.actions = [];
    }

    reducer(state, action) {
      switch(action.type) {
        case 'ADD':
          const {
            payload: {
              name, grade
            }
          } = action;
          const gradeExists = state[grade];

          if (!gradeExists) {
            return {
              ...state,
              [grade]: [name]
            }
          }

          return {
            ...state,
            [grade]: state[grade].concat(name).sort()
          }
        default: return state;
      }
    }

    dispatch(action) {
      this.actions.push(action);
    }

    roster() {
      return this.actions.reduce(this.reducer, {})
    }

    add(name, grade) {
      this.dispatch({
        type: 'ADD',
        payload: {
          name,
          grade
        }
      });
    }

    grade(grade) {
      return this.roster()[grade] || [];
    }
}
