namespace Dimensionamento.Entities.Costado
{
	public class DadosFullView
    {		
		public DadosInputs Inputs { get; set; }
		public DadosOutputs Outputs { get; set; }

		public DadosFullView(DadosInputs inputs, DadosOutputs outputs)
		{
			Inputs = new DadosInputs(inputs);
			Outputs = new DadosOutputs(outputs);
		}
	}
}
