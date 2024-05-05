import React, { useCallback, useEffect, useState } from 'react';
import './App.css';
// import { getListEmail } from './slides/email';
// import useDispatch from './hook/use-dispatch';
// import useSelector from './hook/use-selector';
// import EmailList from './component/email-list/EmailList';
// import emailService from './services/emailService';
// import LeftSide from './component/left-side/LeftSide';
// import { Button } from 'antd';
// import Navbar from './component/nav-bar/NavBar';
//import syllabusArray from './data'
import { Space, Tag } from 'antd';
import Table, { ColumnsType } from 'antd/es/table';
import syllabusService from './services/syllabusService';
import trainingClassService from './services/training-class/trainingClassService';
import RequestParam from './model/request/request';



function App() {
  var clientId = process.env.REACT_APP_CLIENT_KEY
  var returnURL = process.env.REACT_APP_RETURN_URL

  // const dispatch = useDispatch();
  // const { emailList } = useSelector((state) => state.email);
  // const getProjectFolderData = useCallback(() => {
  //   dispatch(getListEmail());
  // }, [dispatch]);


  const getSyllabus = async () => {
    var request: RequestParam = { pageIndex: 1, pageSize: 3 }
    var res = await trainingClassService.getTrainingClasses(request)
    console.log(res);
  }


  useEffect(() => {
    getSyllabus();
  }, [])

  interface DataType {
    key: string;
    name: string;
    age: number;
    address: string;
    tags: string[];
  }

  interface Syllabus {
    syllabusName: string;
    code: string;
    created: string;
    createdBy: string;
    duration: number;
    outputStandards: string[];
  }

  const columns: ColumnsType<Syllabus> = [
    {
      title: 'syllabusName',
      dataIndex: 'syllabusName',
      key: 'syllabusName',
    },
    {
      title: 'code',
      dataIndex: 'code',
      key: 'code',
    },
    {
      title: 'created',
      dataIndex: 'created',
      key: 'created',
    },
    {
      title: 'createdBy',
      dataIndex: 'createdBy',
      key: 'createdBy',
    },
    {
      title: 'duration',
      dataIndex: 'duration',
      key: 'duration',
    },
    {
      title: 'outputStandards',
      key: 'outputStandards',
      dataIndex: 'outputStandards',
      render: (_, { outputStandards }) => (
        <>
          {outputStandards.map((tag) => {
            let color = tag.length > 5 ? 'geekblue' : 'green';
            if (tag === 'loser') {
              color = 'volcano';
            }
            return (
              <Tag color={color} key={tag}>
                {tag.toUpperCase()}
              </Tag>
            );
          })}
        </>
      ),
    },

  ];

  const syllabusArray: Syllabus[] = [
    {
      syllabusName: "Digital Marketing Fundamentals",
      code: "DM101",
      created: "2022-02-01",
      createdBy: "Sarah Lee",
      duration: 8, // duration in weeks
      outputStandards: ["F3N6", "HG84G"]
    },
    {
      syllabusName: "World History",
      code: "HIST101",
      created: "2021-09-01",
      createdBy: "David Kim",
      duration: 14, // duration in weeks
      outputStandards: ["H8K2", "HG84G", "GJ84C"]
    },
    {
      syllabusName: "Spanish I",
      code: "SPAN101",
      created: "2022-04-15",
      createdBy: "Ana Rodriguez",
      duration: 12, // duration in weeks
      outputStandards: ["H8K2", "HJN632", "GJ84C"]
    },
    {
      syllabusName: "Java Programming",
      code: "JAVA101",
      created: "2021-12-01",
      createdBy: "Alex Chen",
      duration: 16, // duration in weeks
      outputStandards: ["H8K2", "HG84G", "GJ84C"]
    },
    {
      syllabusName: "Organic Chemistry",
      code: "CHEM201",
      created: "2022-05-01",
      createdBy: "Emily Wong",
      duration: 10, // duration in weeks
      outputStandards: ["OBV432"]
    }
  ];


  return (
    <div className="App">
      <Table columns={columns} dataSource={syllabusArray} />
    </div>
  );
}

export default App;
