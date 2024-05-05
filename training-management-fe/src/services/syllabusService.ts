import httpClient from "../httpClient/httpClient";
import  RequestParam  from "../model/request/request";
import { SyllabusView } from "../model/syllabus/syllabus";
import apiLinks from "../util/api-link";



const getListSyllabus = async (): Promise<SyllabusView[]> => {
     
      var params: RequestParam = {
        pageSize: 0,
        pageIndex: 1,
      };

    const response = await httpClient.get({
        url: `${apiLinks.syllabus.get_syllabus}?pageSize=0&pageIndex=1`,
        params:{params},
    });
    // const { result } = response.data as EmailResponse;
    return response.data as SyllabusView[];
};


const syllabusService = {
    getListSyllabus
  };
  export default syllabusService;