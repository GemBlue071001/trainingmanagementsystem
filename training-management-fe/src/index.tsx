import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import { Provider } from 'react-redux';
import store from './store/store';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import {
  createBrowserRouter,
  RouterProvider,
} from "react-router-dom";
import SendMail from './component/send-mail/SendMail';

const router = createBrowserRouter([
  {
    path: "/",
    element: <App/>,
    errorElement:<div>Dang!</div>
  },
  {
    path: "/new-mail",
    element: <SendMail/>,
    errorElement:<div>Dang!</div>
  }
 
]);

const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);
root.render(
  
    <Provider store={store}>
      <RouterProvider router={router} />
      
    </Provider>
 
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
