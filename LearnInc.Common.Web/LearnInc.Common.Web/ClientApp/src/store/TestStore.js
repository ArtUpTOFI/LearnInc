const requestTestRecordsType = 'REQUEST_TEST_RECORDS';
const receiveTestRecordsType = 'RECEIVE_TEST_RECORDS';
const initialState = { testRecords: [], isLoading: false };

export const actionCreators = {
  requestTestRecords: () => async (dispatch) => {    
    dispatch({ type: requestTestRecordsType });

    const url = `api/test/`;
    const response = await fetch(url);
    const testRecords = await response.json();

    dispatch({ type: receiveTestRecordsType, testRecords });
  }
};

export const reducer = (state, action) => {
  state = state || initialState;

  if (action.type === requestTestRecordsType) {
    return {
      ...state,
      isLoading: true
    };
  }

  if (action.type === receiveTestRecordsType) {
    return {
      ...state,
      testRecords: action.testRecords,
      isLoading: false
    };
  }

  return state;
};
