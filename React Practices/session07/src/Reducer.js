export const initialState = {
  tasks: [
    { title: "book", done: false },
    { title: "Shop", done: false },
    { title: "Bank", done: false },
  ],
  newText: "",
};

export const Reducer = (state, action) => {

  const saveStateToLocal = (updatedState) => {
    localStorage.setItem('tasksState', JSON.stringify(updatedState));
  };

  switch (action.type) {

    case "ADD_TASK":
      
      // .some() checks if the array have at least 1 element
      if (state.tasks.some(task => task.title === state.newText)) {
        alert("Duplicated Task");
        return state;
      } else {
        const newState = {
          ...state,
          tasks: [...state.tasks, { title: state.newText, done: false }],
          newText: "",
        };

        saveStateToLocal(newState);

        return newState;
      }
    case "DELETE_TASK":
      const deletedState = {
        ...state,
        tasks: state.tasks.filter(
          (task) => task.title !== action.payload.title
        ),
      };

      saveStateToLocal(deletedState);

      return deletedState;
    case "TOGGLE_TASK":
      const toggledState = {
        ...state,
        tasks: state.tasks.map((task) =>
          task.title === action.payload.title
            ? { ...task, done: !task.done }
            : task
        ),
      };

      saveStateToLocal(toggledState);

      return toggledState;
    case "UPDATE_NEW_TEXT":
      const updatedState = {
        ...state,
        newText: action.payload,
      };

      saveStateToLocal(updatedState);

      return updatedState;
    default:
      return state;
  }
};
