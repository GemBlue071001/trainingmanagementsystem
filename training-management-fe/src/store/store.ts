import { configureStore } from '@reduxjs/toolkit';

import appReducers from '../slides';



const store = configureStore({
  reducer: {
    ...appReducers,
  }
});

export type AppDispatch = typeof store.dispatch;
export type AppState = ReturnType<typeof store.getState>;

export default store;
