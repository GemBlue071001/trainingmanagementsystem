import { useSelector as _useSelector, TypedUseSelectorHook } from 'react-redux';
import { AppState } from '../store/store';
const useSelector: TypedUseSelectorHook<AppState> = _useSelector;
export default useSelector;