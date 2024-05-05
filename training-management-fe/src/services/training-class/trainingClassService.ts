import httpClient from "../../httpClient/httpClient";
import RequestParam from "../../model/request/request";
import {  TrainingClassPagination, TrainingClassResponse } from "../../model/training-class/trainingClass";
import apiLinks from "../../util/api-link";

const getTrainingClasses = async (params: RequestParam): Promise<TrainingClassPagination> => {
    const response = await httpClient.get({
        url: `${apiLinks.trainingClass.get_training_class}`,
        params: {
            pageIndex: params.pageIndex,
            pageSize: params.pageSize,
        },
    });
    const { result } = response.data as TrainingClassResponse;
    return result;
};
const trainingClassService = {
    getTrainingClasses
  };
  export default trainingClassService;