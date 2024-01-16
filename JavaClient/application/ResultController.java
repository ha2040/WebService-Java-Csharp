package application;

import java.awt.Button;
import javafx.event.ActionEvent;
import java.awt.event.KeyEvent;
import java.awt.event.MouseEvent;
import java.net.URL;
import java.rmi.RemoteException;
import java.util.ArrayList;
import java.util.Optional;
import java.util.ResourceBundle;

import javafx.beans.property.SimpleStringProperty;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Node;
import javafx.scene.Scene;
import javafx.scene.control.Alert;
import javafx.scene.control.ButtonType;
import javafx.scene.control.Label;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.layout.AnchorPane;
import javafx.stage.Stage;
import javafx.scene.control.Alert.AlertType;
import se.lu.ics.ResultDTO;
import se.lu.ics.FacultyDTO;
import se.lu.ics.KebabUniServiceSoap;
import se.lu.ics.KebabUniServiceSoapProxy;
import se.lu.ics.StudentDTO;

public class ResultController implements Initializable {
	private KebabUniServiceSoap web = new KebabUniServiceSoapProxy();
    ObservableList<ResultDTO> resultList = FXCollections.observableArrayList();

    @FXML
    private TableColumn<ResultDTO, String> columnExamId;

    @FXML
    private TableColumn<ResultDTO, String> columnPoints;

    @FXML
    private TableColumn<ResultDTO, String> columnStudentId;

    @FXML
    private Label lblResponse;

    @FXML
    private TableView<ResultDTO> tblViewResult;

    @FXML
    private TextArea txtError;
	private Main main;
	   private Stage stage;
		private Scene scene;
		private AnchorPane root;
	

	@FXML
	public void btnSwitchToCourses(ActionEvent event) throws Exception {
		FXMLLoader loader = new FXMLLoader(getClass().getResource("CoursesScene.fxml"));
		root = loader.load();
		stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
		scene = new Scene(root);

		stage.setScene(scene);
		stage.show();

		CoursesController coursesController = loader.getController();
		coursesController.setMain(main);
	}

	@FXML
	public void btnSwitchToEmployees(ActionEvent event) throws Exception {
		FXMLLoader loader = new FXMLLoader(getClass().getResource("EmployeeScene.fxml"));
		root = loader.load();
		stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
		scene = new Scene(root);

		stage.setScene(scene);
		stage.show();

		EmployeeController employeeController = loader.getController();
		employeeController.setMain(main);
	}

	@FXML
	public void btnSwitchToExams(ActionEvent event) throws Exception {
		FXMLLoader loader = new FXMLLoader(getClass().getResource("ExamsScene.fxml"));
		root = loader.load();
		stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
		scene = new Scene(root);

		stage.setScene(scene);
		stage.show();

		ExamsController examsController = loader.getController();
		examsController.setMain(main);
	}

	@FXML
	public void btnSwitchToFaculties(ActionEvent event) throws Exception {
		FXMLLoader loader = new FXMLLoader(getClass().getResource("FacultyScene.fxml"));
		root = loader.load();
		stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
		scene = new Scene(root);

		stage.setScene(scene);
		stage.show();

		FacultyController facultyController = loader.getController();
		facultyController.setMain(main);
	}

	@FXML
	public void btnSwitchToHome(ActionEvent event) throws Exception {
		FXMLLoader loader = new FXMLLoader(getClass().getResource("HomeScene.fxml"));
		root = loader.load();
		stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
		scene = new Scene(root);

		stage.setScene(scene);
		stage.show();

		HomeController homeController = loader.getController();
		homeController.setMain(main);
	}

	@FXML
	public void btnSwitchToStudents(ActionEvent event) throws Exception {
		FXMLLoader loader = new FXMLLoader(getClass().getResource("StudentsScene.fxml"));
		root = loader.load();
		stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
		scene = new Scene(root);

		stage.setScene(scene);
		stage.show();

		StudentsController studentsController = loader.getController();
		studentsController.setMain(main);
	}
    
    @Override
	public void initialize(URL url, ResourceBundle resourceBundle) {
		
			 

			    try { 
			        ResultDTO[] resultDtos = web.getResults();
			        
			        for (ResultDTO result : resultDtos) {
			        	ResultDTO resultCopy = new ResultDTO(
			        			result.getExam(),
			        			result.getStudent(),
			        			result.getPoints()
			               
			            );
			        	resultList.add(resultCopy);
			            
			            
			          
			        }
			        
			    } catch (RemoteException e) {
			    	txtError.setText(e.getMessage());
			    }
			    
			 

			    columnStudentId.setCellValueFactory(cellData -> {
				    String studentId = cellData.getValue().getStudent().getStudentId();
				    return new SimpleStringProperty(studentId);
				});
			    columnExamId.setCellValueFactory(cellData -> {
				    String examId = cellData.getValue().getExam().getExamID();
				    return new SimpleStringProperty(examId);
				});
		columnPoints.setCellValueFactory(new PropertyValueFactory<>("points"));
		
		tblViewResult.setItems(resultList);

	}

    
    public void setMain(Main main) {
		
		this.main = main;
	}
	public Main getMain() 
	{
		return this.main;
	}

}

